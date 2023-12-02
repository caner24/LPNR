using PlatePass.Business.Abstract;
using PlatePass.Business.DI;
using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlatePass.Panels
{
    public partial class PlateDetail : UserControl
    {
        public PlateDetail()
        {
            InitializeComponent();
            _plateService = InstanceFactory.GetInstance<IPlateService>();
            _plateDetailService = InstanceFactory.GetInstance<IPlateDetailService>();
        }
        private int plateId;
        private readonly IPlateService _plateService;
        private readonly IPlateDetailService _plateDetailService;

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgwGecis.Rows.Clear();
            dgwGecis.Columns.Clear();
            dgwGecis.Refresh();

            if (!String.IsNullOrWhiteSpace(tbxPlate.Text.ToString()))
            {
                var plates = await _plateDetailService.GetAllEntityAsync(x => x.Plate.PlateText == tbxPlate.Text.ToString());
                if (plates != null)
                {

                    dgwGecis.AutoGenerateColumns = false;

                    // Add columns manually
                    dgwGecis.Columns.Add("Id", "ID");
                    dgwGecis.Columns.Add("PassDate", "Pass Date");
                    dgwGecis.Columns.Add("PlateId", "Plate ID");
                    dgwGecis.Columns.Add("PlateText", "Plate");

                    // Bind data to DataGridView
                    foreach (var plateDetails in plates)
                    {
                        // Assuming Plate has a property named "Name"
                        dgwGecis.Rows.Add(plateDetails.Id, plateDetails.PassDate, plateDetails.PlateId, plateDetails.Plate.PlateText);
                    }
                }
                else
                {
                    MessageBox.Show("Bu plaka adresine kayıtlı araç bulunamadı !.");
                }
            }
            else
            {
                MessageBox.Show("Plaka alanı boş bırakılamaz !.");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await _plateService.DeleteEntityByIdentityAsync(tbxPlate.Text);
        }

        private async void dgwGecis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgwGecis.Rows[e.RowIndex].Cells["PlateText"].Value.ToString();
            var plate = await _plateService.GetEntityByIdentityAsync(x => x.PlateText == id);
            plateId = plate.Id;
            tbxEmail.Text = plate.User.EmailAdres;
            tbxName.Text = plate.User.UserName;
            tbxSurname.Text = plate.User.UserSurname;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Plate plate = new Plate();
            plate.Id = plateId;
            plate.PlateText = tbxPlate.Text.ToString();
            plate.User = new User();
            plate.User.UserName = tbxName.Text.ToString();
            plate.User.UserSurname = tbxSurname.Text.ToString();
            plate.User.EmailAdres = tbxEmail.Text.ToString();
            await _plateService.UpdateEntityAsync(plate);
        }
    }
}
