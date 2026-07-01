using desktop_web_proj1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_web_proj1
{
    public partial class formShoeInventoryApplication : Form
    {
        public formShoeInventoryApplication()
        {
            InitializeComponent();
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            //to improve rendering of desktop gui
            base.OnHandleCreated(e);
            this.DoubleBuffered = true;
        }
        private void formShoeInventoryApplication_Load(object sender, EventArgs e)
        {
            //form load event handler

            //section label message data
            labelGetAllShoeItemsSectionDetailsData.Text = string.Empty;
            labelGetShoeItemByIdSectionDetailsData.Text = string.Empty;
            labelAddShoeItemSectionDetailsData.Text = string.Empty;
            labelEditShoeItemSectionDetailsData.Text = string.Empty;
            labelDeleteShoeItemByIdSectionMessageData.Text = string.Empty;

            // Make header font bold
            dataGridViewGetAAllShoeItem.ColumnHeadersDefaultCellStyle.Font = new Font(
                dataGridViewGetAAllShoeItem.Font, FontStyle.Bold
            );
        }

        private void labelGetShoeItemByIdSectionDetails_Click(object sender, EventArgs e)
        {

        }

        private async void buttonGetAllShoeItemSeectionGetShoeList_Click(object sender, EventArgs e)
        {
            //refresh list button
            
            //get all shoe items
            string apiUrl = "https://localhost:44390/api/Application/getAllListShoeInventory";
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send GET request
                    HttpResponseMessage httpResponseMessage = await client.GetAsync(apiUrl);
                    // Ensure success status code
                    httpResponseMessage.EnsureSuccessStatusCode();
                    // Read response as string
                    string httpResponseMessageContent = await httpResponseMessage.Content.ReadAsStringAsync();
                    
                    List<ShoeInventoryTableModel> listShoeInventoryTableModel =
                        JsonSerializer.Deserialize<List<ShoeInventoryTableModel>>(httpResponseMessageContent);
                    //return status ok (200)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        dataGridViewGetAAllShoeItem.DataSource = null;
                        dataGridViewGetAAllShoeItem.DataSource = listShoeInventoryTableModel;
                        dataGridViewGetAAllShoeItem.Refresh();

                        labelGetAllShoeItemsSectionDetailsData.Text = "data obtained.";
                    }
                    //return no data record 
                    if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                    {
                        dataGridViewGetAAllShoeItem.DataSource = null;
                        dataGridViewGetAAllShoeItem.Refresh();
                        labelGetAllShoeItemsSectionDetailsData.Text = "no records.";

                    }
                    
                }
                catch (HttpRequestException httpRequestException)
                {
                    labelGetAllShoeItemsSectionDetailsData.Text = "request error: " + httpRequestException.Message;

                }

            }

        }

        private void buttonGetShoeItemByIdClearAll_Click(object sender, EventArgs e)
        {
            //get shoe item by id, clear all button
            textBoxoGetShoeItemByIdSectionEnterShoeId.Text = string.Empty;
            labelGetShoeItemByIdSectionDetailsData.Text = string.Empty;
            textBoxoGetShoeItemByIdSectionEnterShoeId.Focus();

        }

        private void tabPageGetShoeItemById_Click(object sender, EventArgs e)
        {

        }

        private void textBoxoGetShoeItemByIdSectionEnterShoeId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void buttonGetShoeItemByIdSubmit_Click(object sender, EventArgs e)
        {
            //get shoe item by id, submit button
            //get shoe item by id, submit button
            int shoeIdUserInput;
            if (textBoxoGetShoeItemByIdSectionEnterShoeId.Text == string.Empty)
            {
                labelGetShoeItemByIdSectionDetailsData.Text = "please enter a shoe id.";
                return;
            }

            if (!int.TryParse(textBoxoGetShoeItemByIdSectionEnterShoeId.Text, out shoeIdUserInput))
            {
                labelGetShoeItemByIdSectionDetailsData.Text = "please enter a valid value."; 
                return;
            }

            string url = "https://localhost:44390/api/Application/getShoeInventoryItemId";
            url = url + "?id=" + shoeIdUserInput.ToString();
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Send GET request
                    HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                    //not found status (404)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                    {
                        labelGetShoeItemByIdSectionDetailsData.Text =
                            "shoe item with id " + shoeIdUserInput.ToString() + " not found.";
                    }
                    //ok status (200)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        string httpResponseMessageContent = await httpResponseMessage.Content.ReadAsStringAsync();
                        ShoeInventoryTableModel shoeInventoryTableModel = JsonSerializer.Deserialize<ShoeInventoryTableModel>(httpResponseMessageContent);
                        string shoeId2 = shoeInventoryTableModel.id.ToString();
                        string shoeName = shoeInventoryTableModel.shoeName;
                        string shoeDescription = shoeInventoryTableModel.shoeDescription;
                        string shoePrice = shoeInventoryTableModel.shoePrice;
                        string shoeSize = shoeInventoryTableModel.shoeSize.ToString();
                        string shoeQuantity = shoeInventoryTableModel.quantity.ToString();
                        string content = "Id: " + shoeId2 + "\n" +
                            "Shoe Name: " + shoeName + "\n" +
                            "shoe description: " + shoeDescription + "\n" +
                            "Shoe Price: " + shoePrice + "\n" +
                            "Shoe Size: " + shoeSize + "\n" +
                            "Shoe Quantity: " + shoeQuantity;
                        labelGetShoeItemByIdSectionDetailsData.Text = content;
                    }
                }
                catch (HttpRequestException httpRequestException)
                {
                    labelGetShoeItemByIdSectionDetailsData.Text = "Request error: " +
                        httpRequestException.Message;
                }
            }
        }

        private void buttonAddShoeItemSectionClearAll_Click(object sender, EventArgs e)
        {
            //add shoe item section, clear all button
            textBoxAddShoeItemSectionShoeId.Text = string.Empty;
            textBoxAddShoeItemSectionShoeName.Text = string.Empty;
            textBoxAddShoeItemSectionShoeDescription.Text = string.Empty;
            textBoxAddShoeItemSectionShoePrice.Text = string.Empty;
            textBoxAddShoeItemSectionShoeSize.Text = string.Empty;   
            textBoxAddShoeItemSectionQuantity.Text = string.Empty;
            labelAddShoeItemSectionDetailsData.Text = string.Empty;
            textBoxAddShoeItemSectionShoeId.Focus();
        }

        private async void buttonAddShoeSubmit_Click(object sender, EventArgs e)
        {
            //add shoe item section, submit button
            string shoeIdStr = textBoxAddShoeItemSectionShoeId.Text.Trim();
            if (shoeIdStr == string.Empty)
            {
                labelAddShoeItemSectionDetailsData.Text = "shoe id cannot be empty.";
                textBoxAddShoeItemSectionShoeId.Focus();
                return; 
            }
            int shoeId;
            if (!int.TryParse(textBoxAddShoeItemSectionShoeId.Text.Trim(), out shoeId))
            {
                labelAddShoeItemSectionDetailsData.Text = "shoe id entered is not valid.";
                textBoxAddShoeItemSectionShoeId.Focus();
                return;
            }
            string shoeName = textBoxAddShoeItemSectionShoeName.Text.Trim();
            if (shoeName == string.Empty)
            {
                shoeName = "n/a";
            }
            string shoeDescription = textBoxAddShoeItemSectionShoeDescription.Text.Trim();
            if (shoeDescription == string.Empty)
            {
                shoeDescription = "n/a";
            }
            string shoePrice = textBoxAddShoeItemSectionShoePrice.Text.Trim();
            if (shoePrice == string.Empty)
            {
                shoePrice = "n/a";
            }
            int shoeSize;
            if (!int.TryParse(textBoxAddShoeItemSectionShoeSize.Text.Trim(), out shoeSize))
            {
                shoeSize = 0;
            }
            int shoeQuantity;
            if (!int.TryParse(textBoxAddShoeItemSectionQuantity.Text.Trim(), out shoeQuantity))
            {
                shoeQuantity = 0;
            }
            ShoeInventoryTableModel shoeInventoryTableModel = new ShoeInventoryTableModel();
            shoeInventoryTableModel.id = shoeId;
            shoeInventoryTableModel.shoeName = shoeName;
            shoeInventoryTableModel.shoeDescription = shoeDescription;
            shoeInventoryTableModel.shoePrice = shoePrice;
            shoeInventoryTableModel.shoeSize = shoeSize;
            shoeInventoryTableModel.quantity = shoeQuantity;
            string url = "https://localhost:44390/api/Application/addNewShoeInventoryItem2";
            // Serialize to JSON
            string jsonContent = JsonSerializer.Serialize(shoeInventoryTableModel);
            // Wrap JSON in HttpContent
            HttpContent httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Send POST request
                    HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(url, httpContent);
                    //bad request 
                    if (httpResponseMessage.StatusCode == HttpStatusCode.BadRequest)
                    {
                        string httpResponseMessageContent = await httpResponseMessage.Content.ReadAsStringAsync();
                        labelAddShoeItemSectionDetailsData.Text = httpResponseMessageContent;
                    }
                    //ok (200)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        labelAddShoeItemSectionDetailsData.Text = "new shoe item added.";
                    }
                }
                catch (HttpRequestException httpRequestException)
                {
                    labelAddShoeItemSectionDetailsData.Text = "Request error: " + httpRequestException.Message;
                }
            }
        }

        private void labelAddShoeItemSectionShoeSize_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditSectionClearAll_Click(object sender, EventArgs e)
        {
            //edit shoe item section, clear all button
            textBoxEditShoeItemSectionShoeId.Text = string.Empty;
            textBoxEditShoeItemSectionShoeName.Text = string.Empty;
            textBoxEditShoeItemSectionShoeDescription.Text = string.Empty;
            textBoxEditShoeItemSectionShoePrice.Text = string.Empty;
            textBoxEditShoeItemSectionShoeSize.Text = string.Empty;
            textBoxEditShoeItemSectionQuantity.Text = string.Empty;
            labelEditShoeItemSectionDetailsData.Text = string.Empty;
            textBoxEditShoeItemSectionShoeId.Focus();
        }

        private async void buttonEditSectionSubmit_Click(object sender, EventArgs e)
        {
            //edit shoe item section, submit button
            string shoeIdStr = textBoxEditShoeItemSectionShoeId.Text.Trim();
            if (shoeIdStr == string.Empty)
            {
                labelEditShoeItemSectionDetailsData.Text = "shoe id cannot be empty.";
                textBoxEditShoeItemSectionShoeId.Focus();
                return;
            }
            int shoeId;
            if (!int.TryParse(textBoxEditShoeItemSectionShoeId.Text.Trim(), out shoeId))
            {
                labelEditShoeItemSectionDetailsData.Text = "shoe id entered is not valid.";
                textBoxEditShoeItemSectionShoeId.Focus();
                return;
            }
            string shoeName = textBoxEditShoeItemSectionShoeName.Text.Trim();
            if (shoeName == string.Empty)
            {
                shoeName = "n/a";
            }
            string shoeDescription = textBoxEditShoeItemSectionShoeDescription.Text.Trim();
            if (shoeDescription == string.Empty)
            {
                shoeDescription = "n/a";
            }
            string shoePrice = textBoxEditShoeItemSectionShoePrice.Text.Trim();
            if (shoePrice == string.Empty)
            {
                shoePrice = "n/a";
            }
            int shoeSize;
            if (!int.TryParse(textBoxEditShoeItemSectionShoeSize.Text.Trim(), out shoeSize))
            {
                shoeSize = 0;
            }
            int shoeQuantity;
            if (!int.TryParse(textBoxEditShoeItemSectionQuantity.Text.Trim(), out shoeQuantity))
            {
                shoeQuantity = 0;
            }
            ShoeInventoryTableModel shoeInventoryTableModel = new ShoeInventoryTableModel();
            shoeInventoryTableModel.id = shoeId;
            shoeInventoryTableModel.shoeName = shoeName;
            shoeInventoryTableModel.shoeDescription = shoeDescription;
            shoeInventoryTableModel.shoePrice = shoePrice;
            shoeInventoryTableModel.shoeSize = shoeSize;
            shoeInventoryTableModel.quantity = shoeQuantity;

            string url = "https://localhost:44390/api/Application/updateShoeInventoryItemDetail";
            // Serialize to JSON
            string jsonContent = JsonSerializer.Serialize(shoeInventoryTableModel);
            // Wrap JSON in HttpContent
            HttpContent httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(url, httpContent);
                    //bad request (400)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.BadRequest)
                    {
                        string httpResponseMessageContent = await httpResponseMessage.Content.ReadAsStringAsync();
                        labelEditShoeItemSectionDetailsData.Text = httpResponseMessageContent;
                    }
                    //not found (404)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                    {
                        labelEditShoeItemSectionDetailsData.Text = "shoe item with entered id not found.";

                    }
                    //ok (200)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        labelEditShoeItemSectionDetailsData.Text = "shoe item details edit successfully.";
                    }
                }
                catch (HttpRequestException httpRequestException)
                {
                    labelEditShoeItemSectionDetailsData.Text = "Request error: " + httpRequestException.Message + ". ";
                }
            }

        }

        private void buttonDeleteShoeItemClearAll_Click(object sender, EventArgs e)
        {
            //delete shoe item section, clear all button
            textBoxDeleteShoeItemSectionEnterShoeId.Text = string.Empty;
            labelDeleteShoeItemByIdSectionMessageData.Text = string.Empty;
            textBoxDeleteShoeItemSectionEnterShoeId.Focus();    
        }

        private async void buttonDeleteShoeItemSubmit_Click(object sender, EventArgs e)
        {
            //delete shoe item section, submit button
            string shoeIdStr = textBoxDeleteShoeItemSectionEnterShoeId.Text.Trim();
            if (shoeIdStr == string.Empty)
            {
                labelDeleteShoeItemByIdSectionMessageData.Text = "shoe id cannot be empty.";
                textBoxDeleteShoeItemSectionEnterShoeId.Focus();
                return;
            }
            int shoeId;
            if (!int.TryParse(textBoxDeleteShoeItemSectionEnterShoeId.Text.Trim(), out shoeId))
            {
                labelDeleteShoeItemByIdSectionMessageData.Text = "shoe id entered is not valid.";
                textBoxDeleteShoeItemSectionEnterShoeId.Focus();
                return;
            }


            string url = "https://localhost:44390/api/Application/deleteShoeInventoryItemId";
            url = url + "?shoeId=" + shoeId.ToString();
            //url = url + "?id=" + shoeId.ToString();
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync(url);
                    //not found (404)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                    {
                        labelDeleteShoeItemByIdSectionMessageData.Text =
                            "shoe item with entered id not found.";
                    }
                    //ok (200)
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        labelDeleteShoeItemByIdSectionMessageData.Text =
                            "shoe item deleted successfully.";
                    }
                }
                catch (HttpRequestException httpRequestException)
                {
                    labelDeleteShoeItemByIdSectionMessageData.Text =
                        "Request error: " + httpRequestException.Message + ". ";
                }
            }


        }
    }
}
