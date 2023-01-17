using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje.Models;

namespace Proje
{
    public partial class OgrDersFormu : Form
    {
        ProjeConnectionOkulDbEntities DB = new ProjeConnectionOkulDbEntities();

        public OgrDersFormu()
        {
            InitializeComponent();
        }

        private void OgrDers_Load(object sender, EventArgs e)
        {
            dataGridViewOgrenciDers.DataSource = DB.OgrenciDers.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewOgrenciDers.CurrentRow.Cells[0].Value.ToString());

            OgrenciDers ogdsil = DB.OgrenciDers.FirstOrDefault(x => x.ID == id);

            DialogResult sor = MessageBox.Show($@"{ogdsil.DersID} Dersini Silmek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
            if (sor == DialogResult.Yes)
            {
                DB.OgrenciDers.Remove(ogdsil);
                DB.SaveChanges();
                dataGridViewOgrenciDers.DataSource = DB.OgrenciDers.ToList();

                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Silme İşleminiz İptal Edildi!");
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text.Trim() == string.Empty) 
            {
                return;
            }
            var id = int.Parse(txtAra.Text.Trim());
            var ddd = DB.OgrenciDers.Where(x => x.DersID == id || x.OgrenciID == id)
                      .Select(x => new
                      {
                          x.ID,
                          x.DersID,
                          x.OgrenciID
                      }
                        );
            dataGridViewOgrenciDers.DataSource = ddd.ToList();
        }
    }
}