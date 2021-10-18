using GruberGerichteWeb.Client.Shared;
using GruberGerichteWeb.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace GruberGerichteWeb.Client.Pages
{
    public class GerichteListBase : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<Gerichte> GeList = new List<Gerichte>();

        public string MenssageDelete { get; set; }

        public bool AlertIsVisible = false;
        public string AlertMessage { get; set; }

        //Instance of confirm message
        public Confirm confirm;

        public string idgerichte = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            await GetGerichteList();
        }

        async Task GetGerichteList()
        {
            try
            {
                GeList = await Http.GetFromJsonAsync<List<Gerichte>>("api/Gerichte");
            }
            catch(Exception ex)
            {
                AlertIsVisible = true;
                AlertMessage = ex.ToString();
            }
        }


        public void DeleteGerichte(string id)
        {
            try
            {
                confirm.Show();
                idgerichte = id;
                MenssageDelete = "Delete id: " + idgerichte;
            }
            catch (Exception ex)
            {
                AlertIsVisible = true;
                AlertMessage = ex.ToString();
            }
        }
        public async Task DeleteConfirm()
        {
            try
            {
                confirm.Hide();
                await Http.DeleteAsync($"api/Gerichte/{idgerichte}");
                this.StateHasChanged();
                await GetGerichteList();
            }
            catch (Exception ex)
            {
                AlertIsVisible = true;
                AlertMessage = ex.ToString();
            }
        }

        public void CancelConfirm()
        {
            confirm.Hide();
        }

    }
}
