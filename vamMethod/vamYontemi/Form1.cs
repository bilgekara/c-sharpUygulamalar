using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace vamYontemi
{
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public static int clicked = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            clicked = 1;
            
            if (textBoxDepoSayisi.Text.Length == 0) MessageBox.Show("Lütfen Depo Sayısını Giriniz");
            else if(textBoxFabrikaSayisi.Text.Length==0)  MessageBox.Show("Lütfen Fabrika Sayısını Giriniz");
            else
            {
                
                int depoSayisi = int.Parse(textBoxDepoSayisi.Text);
                int fabrikaSayisi = int.Parse(textBoxFabrikaSayisi.Text);
                
                int sayi = 1; int k;
                dataGridView1.ColumnCount = depoSayisi + 1;
                for (k = 0; k < depoSayisi; k++)
                {
                    dataGridView1.Columns[k].Name = "Depo " + sayi;
                    sayi++;
                }
                dataGridView1.Columns[k].Name = "Arz";            
                
                dataGridView1.Columns[k].DefaultCellStyle.ForeColor = Color.Brown;
                dataGridView1.Columns[k].DefaultCellStyle.BackColor = Color.Linen;

                int i;
                for ( i = 0; i < fabrikaSayisi; i++)
                {
                    dataGridView1.Rows.Add(); 
                }
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Linen;
                dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Brown;

                dataGridView1.Rows[fabrikaSayisi].Cells[depoSayisi].Value = "Toplam Maliyet";
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
            }

        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            if (clicked == 0)
            {
                MessageBox.Show("İlk olarak verileri ekleyiniz.");
            }
            else
            {
                int fabrikaSayisi = int.Parse(textBoxFabrikaSayisi.Text.ToString()); int deppoSayisi = int.Parse(textBoxDepoSayisi.Text.ToString());

                int[] satirCezalari = new int[fabrikaSayisi]; int enKucukSutun = 0;
                int[] sutunCezalari = new int[deppoSayisi]; int enKucukSatir = 0; 


                if(dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    #region TANIMLAMA
                    int enKucuk = 0; int enBuyuk = 0;
                    enKucuk = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                    enBuyuk = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());

                    int[] enDusukMaliyetSatir = new int[fabrikaSayisi]; int[] enDusukMaliyetSutun = new int[deppoSayisi];

                    int toplamMaliyet = 0;
                    String[] arzDizisi = new String[fabrikaSayisi]; String[] talepDizisi = new String[deppoSayisi];
                    for (int i = 0; i < deppoSayisi; i++)
                    {
                        talepDizisi[i] = dataGridView1.Rows[fabrikaSayisi].Cells[i].Value.ToString();
                    }
                    for (int i = 0; i < fabrikaSayisi; i++)
                    {
                        arzDizisi[i] = dataGridView1.Rows[i].Cells[deppoSayisi].Value.ToString();
                    }


                    int toplamArz = 0;
                    for (int i = 0; i < arzDizisi.Length; i++)
                    {
                        toplamArz += int.Parse(arzDizisi[i].ToString());
                    }
                    int toplamTalep = 0;
                    for (int i = 0; i < talepDizisi.Length; i++)
                    {
                        toplamTalep += int.Parse(talepDizisi[i]);
                    }

                    if (toplamTalep > toplamArz)
                    {
                        MessageBox.Show("Talep miktari arz miktarından fazla" + "\n" + "-----------yeni satır eklendi-----------");
                        int fark = toplamTalep - toplamArz; int i;
                        for (i = 0; i < deppoSayisi; i++)
                        {
                            dataGridView1.Rows[fabrikaSayisi].Cells[i].Value = 0;
                        }
                        dataGridView1.Rows[fabrikaSayisi].Cells[i].Value = fark; i = 0;
                        dataGridView1.Rows[fabrikaSayisi].DefaultCellStyle.ForeColor = Color.Black;
                        dataGridView1.Rows[fabrikaSayisi].DefaultCellStyle.BackColor = Color.White;

                        dataGridView1.Columns[deppoSayisi].DefaultCellStyle.BackColor = Color.Linen;

                        dataGridView1.Rows[fabrikaSayisi + 1].DefaultCellStyle.ForeColor = Color.Brown;
                        dataGridView1.Rows[fabrikaSayisi + 1].DefaultCellStyle.BackColor = Color.Linen;

                        for (i = 0; i < deppoSayisi; i++)
                        {
                            dataGridView1.Rows[fabrikaSayisi + 1].Cells[i].Value = talepDizisi[i];
                        }
                        dataGridView1.Rows[fabrikaSayisi + 1].Cells[deppoSayisi].Value = "Toplam Maliyet";
                    }
                    else if (toplamArz > toplamTalep)
                    {

                        MessageBox.Show("Arz miktari talep miktarından fazla" + "\n" + "-----------yeni sutün eklendi-----------");
                        dataGridView1.ColumnCount = deppoSayisi + 2;
                        int fark = toplamArz - toplamTalep; int i;
                        for (i = 0; i < fabrikaSayisi; i++)
                        {
                            dataGridView1.Rows[i].Cells[deppoSayisi].Value = 0;
                        }
                        dataGridView1.Columns[deppoSayisi].DefaultCellStyle.ForeColor = Color.Black;
                        dataGridView1.Columns[deppoSayisi].DefaultCellStyle.BackColor = Color.White;

                        dataGridView1.Rows[i].Cells[deppoSayisi].Value = fark; i = 0;
                        dataGridView1.Columns[deppoSayisi].Name = "Depo" + (deppoSayisi + 1);

                        dataGridView1.Columns[deppoSayisi + 1].Name = "Arz";
                        dataGridView1.Columns[deppoSayisi + 1].DefaultCellStyle.ForeColor = Color.Brown;
                        dataGridView1.Columns[deppoSayisi + 1].DefaultCellStyle.BackColor = Color.Linen;


                        for (i = 0; i < fabrikaSayisi; i++)
                        {
                            dataGridView1.Rows[i].Cells[deppoSayisi + 1].Value = arzDizisi[i];
                        }
                        dataGridView1.Rows[fabrikaSayisi].Cells[deppoSayisi + 1].Value = "Toplam Maliyet";


                    } 
                    #endregion



                    #region Satırın En Dusuk Maliyetleri

                    for (int j = 0; j < fabrikaSayisi; j++)
                    {
                        for (int i = 0; i < deppoSayisi; i++)
                        {
                            if (enKucuk > int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString()))
                            {
                                enKucuk = int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                                enKucukSutun = i;
                                enDusukMaliyetSatir[j] = i;
                            }
                        }
                        if (j < fabrikaSayisi)
                        {
                            if (enKucukSutun == 0)
                            {
                                enDusukMaliyetSatir[j] = 0;

                                enBuyuk = int.Parse(dataGridView1.Rows[j].Cells[1].Value.ToString());
                            }
                            else
                            {
                                enBuyuk = int.Parse(dataGridView1.Rows[j].Cells[0].Value.ToString());

                            }
                        }
                        for (int i = 0; i < deppoSayisi; i++)
                        {
                            if (enBuyuk > int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString()) && int.Parse(dataGridView1.Rows[j].Cells[enKucukSutun].Value.ToString()) != int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString()))
                            {
                                enBuyuk = int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                            }
                        }

                        satirCezalari[j] = enBuyuk - enKucuk;

                        if (j + 1 < fabrikaSayisi)
                        {
                            enKucuk = int.Parse(dataGridView1.Rows[j + 1].Cells[0].Value.ToString());

                        }
                        enKucukSutun = 0;

                    }
                    for (int i = 0; i < satirCezalari.Length; i++)
                    {
                        listBoxSatirCezalari.Items.Add((i + 1) + "->" + satirCezalari[i]);
                    }
                    #endregion



                    #region Sutunun En Dusuk Maliyetleri

                    enKucuk = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                    enBuyuk = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());

                    for (int j = 0; j < deppoSayisi; j++)
                    {
                        for (int i = 0; i < fabrikaSayisi; i++)
                        {
                            if (enKucuk > int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString()))
                            {
                                enKucuk = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                enKucukSatir = i;
                                enDusukMaliyetSutun[j] = i;
                            }
                        }
                        if (j < deppoSayisi)
                        {
                            if (enKucukSatir == 0)
                            {
                                enDusukMaliyetSutun[j] = 0;
                                enBuyuk = int.Parse(dataGridView1.Rows[1].Cells[j].Value.ToString());
                            }
                            else
                            {
                                enBuyuk = int.Parse(dataGridView1.Rows[0].Cells[j].Value.ToString());

                            }
                        }

                        for (int i = 0; i < fabrikaSayisi; i++)
                        {
                            if (enBuyuk > int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString()) && enKucuk != int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString()))
                            {
                                enBuyuk = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            }
                        }

                        sutunCezalari[j] = enBuyuk - enKucuk;

                        if (j + 1 < deppoSayisi)
                        {
                            enKucuk = int.Parse(dataGridView1.Rows[0].Cells[j + 1].Value.ToString());
                        }

                        enKucukSatir = 0;
                    }
                    for (int i = 0; i < sutunCezalari.Length; i++)
                    {
                        listBoxSutunCezalari.Items.Add((i + 1) + "->" + sutunCezalari[i]);
                    }
                    #endregion




                    #region En Buyuk Ceza ve Nerede?
                    int enBuyukSatirCezasi = 0;
                    int enBuyukSutunCezasi = 0;

                    int hangiSatir = 0;
                    int hangiSutun = 0;

                    enBuyukSatirCezasi = satirCezalari[0];
                    hangiSatir = 0;
                    for (int i = 0; i < 1; i++)
                    {

                        for (int k = 0; k < satirCezalari.Length; k++)
                        {
                            if (satirCezalari[k] > enBuyukSatirCezasi)
                            {
                                enBuyukSatirCezasi = satirCezalari[k];
                                hangiSatir = k;
                            }

                        }

                    }
                    enBuyukSutunCezasi = sutunCezalari[0];
                    hangiSutun = 0;
                    for (int i = 0; i < 1; i++)
                    {

                        for (int k = 0; k < sutunCezalari.Length; k++)
                        {
                            if (sutunCezalari[k] > enBuyukSutunCezasi)
                            {
                                enBuyukSutunCezasi = sutunCezalari[k];
                                hangiSutun = k;
                            }

                        }

                    }
                    #endregion


                    MessageBox.Show("Toplam Maliyet->" + toplamMaliyet);



                    int devamSutun = 0; int devamSatir = 0;



                    while (devamSatir != 1 || devamSutun != 1)
                    {

                        if (enBuyukSatirCezasi > enBuyukSutunCezasi && (devamSutun != 1 || devamSatir != 1))
                        {
                            if (int.Parse(talepDizisi[enDusukMaliyetSatir[hangiSatir]]) > int.Parse(arzDizisi[hangiSatir]))
                            {
                                toplamMaliyet += int.Parse(dataGridView1.Rows[hangiSatir].Cells[enDusukMaliyetSatir[hangiSatir]].Value.ToString()) * int.Parse(arzDizisi[hangiSatir]);

                                int degisken = int.Parse(talepDizisi[enDusukMaliyetSatir[hangiSatir]]) - int.Parse(arzDizisi[hangiSatir]);
                                talepDizisi[enDusukMaliyetSatir[hangiSatir]] = degisken.ToString();
                                int degisken2 = 0;
                                arzDizisi[hangiSatir] = degisken2.ToString();
                                satirCezalari[hangiSatir] = 0;

                                #region Matris Güncelleme
                                for (int j = 0; j < deppoSayisi; j++)
                                {
                                    dataGridView1.Rows[fabrikaSayisi].Cells[j].Value = talepDizisi[j];
                                    continue;
                                }
                                for (int j = 0; j < fabrikaSayisi; j++)
                                {
                                    dataGridView1.Rows[j].Cells[deppoSayisi].Value = arzDizisi[j];
                                    continue;
                                }
                                dataGridView1.Rows[hangiSatir].DefaultCellStyle.BackColor = Color.RosyBrown;
                                dataGridView1.Rows[hangiSatir].DefaultCellStyle.ForeColor = Color.White;
                                MessageBox.Show("Toplam Maliyet->" + toplamMaliyet); 
                                #endregion

                                for (int la = 0; la < fabrikaSayisi; la++)
                                {
                                    if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        for (int ka = 0; ka < deppoSayisi; ka++)
                                        {
                                            if (dataGridView1.Columns[ka].DefaultCellStyle.BackColor != Color.RosyBrown)
                                            {
                                                enKucuk = int.Parse(dataGridView1.Rows[la].Cells[ka].Value.ToString());
                                                enBuyuk = int.Parse(dataGridView1.Rows[la].Cells[ka].Value.ToString());
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                }

                                for (int la = 0; la < fabrikaSayisi; la++)
                                {
                                    if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        devamSatir++;
                                    }
                                }
                                for (int la = 0; la < deppoSayisi; la++)
                                {
                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        devamSutun++;
                                    }
                                }

                                if (devamSatir != 1)
                                {
                                    devamSatir = 0; devamSutun = 0;

                                    #region Sutun Güncelleme
                                    for (int m = 0; m < deppoSayisi; m++)
                                    {
                                        if (dataGridView1.Columns[m].DefaultCellStyle.BackColor != Color.RosyBrown)
                                        {
                                            for (int i = 0; i < fabrikaSayisi; i++)
                                            {
                                                if (enKucuk > int.Parse(dataGridView1.Rows[i].Cells[m].Value.ToString()) && dataGridView1.Rows[i].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                {
                                                    enKucuk = int.Parse(dataGridView1.Rows[i].Cells[m].Value.ToString());
                                                    enKucukSatir = i;
                                                    enDusukMaliyetSutun[m] = i;
                                                }
                                            }

                                            if (m < deppoSayisi)
                                            {
                                                if (enKucukSatir == 0)
                                                {
                                                    for (int la = 0; la < fabrikaSayisi; la++)
                                                    {
                                                        if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                        {
                                                            if (la != enKucukSatir)
                                                            {
                                                                enBuyuk = int.Parse(dataGridView1.Rows[la].Cells[m].Value.ToString()); break;
                                                            }
                                                            else
                                                            {
                                                                enDusukMaliyetSutun[m] = la;
                                                            }
                                                        }
                                                    }
                                                }

                                                if (enKucukSatir != 0)
                                                {
                                                    for (int la = 0; la < fabrikaSayisi; la++)
                                                    {
                                                        if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown && la != enKucukSatir)
                                                        {
                                                            enBuyuk = int.Parse(dataGridView1.Rows[la].Cells[m].Value.ToString());
                                                            break;
                                                        }
                                                    }

                                                }

                                            }

                                            for (int i = 0; i < fabrikaSayisi; i++)
                                            {
                                                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor != Color.RosyBrown && enBuyuk > int.Parse(dataGridView1.Rows[i].Cells[m].Value.ToString()) && i != enKucukSatir)
                                                {
                                                    enBuyuk = int.Parse(dataGridView1.Rows[i].Cells[m].Value.ToString());
                                                }
                                            }
                                            sutunCezalari[m] = enBuyuk - enKucuk;

                                            if (m + 1 < deppoSayisi)
                                            {
                                                for (int la = 0; la < deppoSayisi; la++)
                                                {
                                                    if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                    {
                                                        enKucuk = int.Parse(dataGridView1.Rows[la].Cells[m + 1].Value.ToString());
                                                        break;
                                                    }

                                                }
                                            }

                                            enKucukSatir = 0;
                                        }
                                        else
                                        {
                                            sutunCezalari[m] = 0;

                                            if (m + 1 < deppoSayisi)
                                            {
                                                for (int la = 0; la < deppoSayisi; la++)
                                                {
                                                    if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                    {
                                                        enKucuk = int.Parse(dataGridView1.Rows[la].Cells[m + 1].Value.ToString());
                                                        break;
                                                    }

                                                }

                                            }
                                            continue;
                                        }




                                    }

                                    #endregion

                                    #region ListBox Sutun
                                    listBoxSutunCezalari.Items.Clear();
                                    for (int i = 0; i < sutunCezalari.Length; i++)
                                    {
                                        listBoxSutunCezalari.Items.Add((i + 1) + "->" + sutunCezalari[i]);
                                    }
                                    #endregion

                                    #region ListBox Satır
                                    listBoxSatirCezalari.Items.Clear();
                                    for (int i = 0; i < satirCezalari.Length; i++)
                                    {
                                        listBoxSatirCezalari.Items.Add((i + 1) + "->" + satirCezalari[i]);
                                    }
                                    #endregion

                                    #region En Buyuk Sutun Cezası ne ve Hangi Sutunda?
                                    enBuyukSutunCezasi = sutunCezalari[0];
                                    hangiSutun = 0;

                                    for (int k = 0; k < sutunCezalari.Length; k++)
                                    {
                                        if (sutunCezalari[k] > enBuyukSutunCezasi)
                                        {
                                            enBuyukSutunCezasi = sutunCezalari[k];
                                            hangiSutun = k;
                                        }

                                    }
                                    enBuyukSatirCezasi = satirCezalari[0];
                                    hangiSatir = 0;

                                    for (int k = 0; k < satirCezalari.Length; k++)
                                    {
                                        if (satirCezalari[k] > enBuyukSatirCezasi)
                                        {
                                            enBuyukSatirCezasi = satirCezalari[k];
                                            hangiSatir = k;
                                        }

                                    }
                                    #endregion

                                }

                                else
                                {
                                    devamSutun = 1;
                                    for (int la = 0; la < fabrikaSayisi; la++)
                                    {
                                        if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                        {
                                            hangiSutun = 0;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                toplamMaliyet += int.Parse(dataGridView1.Rows[hangiSatir].Cells[enDusukMaliyetSatir[hangiSatir]].Value.ToString()) * int.Parse(talepDizisi[enDusukMaliyetSatir[hangiSatir]]);

                                int degisken = int.Parse(arzDizisi[hangiSatir]) - int.Parse(talepDizisi[enDusukMaliyetSatir[hangiSatir]]);
                                arzDizisi[hangiSatir] = degisken.ToString();
                                int degisken2 = 0;
                                talepDizisi[enDusukMaliyetSatir[hangiSatir]] = degisken2.ToString();
                                sutunCezalari[enDusukMaliyetSatir[hangiSatir]] = 0;
                                int degisken3 = hangiSatir;
                                #region Matris Güncelleme
                                for (int j = 0; j < deppoSayisi; j++)
                                {
                                    //for (int i = fabrikaSayisi; i < fabrikaSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[i].Cells[j].Value = talepDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[fabrikaSayisi].Cells[j].Value = talepDizisi[j];
                                    continue;
                                }
                                for (int j = 0; j < fabrikaSayisi; j++)
                                {
                                    //for (int i = deppoSayisi; i < deppoSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[j].Cells[i].Value = arzDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[j].Cells[deppoSayisi].Value = arzDizisi[j];
                                    continue;
                                }
                                dataGridView1.Columns[enDusukMaliyetSatir[hangiSatir]].DefaultCellStyle.BackColor = Color.RosyBrown;
                                dataGridView1.Columns[enDusukMaliyetSatir[hangiSatir]].DefaultCellStyle.ForeColor = Color.White;

                                MessageBox.Show("Toplam Maliyet->" + toplamMaliyet); 
                                #endregion

                                for (int la = 0; la < deppoSayisi; la++)
                                {
                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        for (int ka = 0; ka < fabrikaSayisi; ka++)
                                        {
                                            if (dataGridView1.Rows[ka].DefaultCellStyle.BackColor != Color.RosyBrown)
                                            {
                                                enKucuk = int.Parse(dataGridView1.Rows[ka].Cells[la].Value.ToString());
                                                enBuyuk = int.Parse(dataGridView1.Rows[ka].Cells[la].Value.ToString());
                                                break;
                                            }
                                        }


                                        break;
                                    }

                                }
                                for (int ka = 0; ka < fabrikaSayisi; ka++)
                                {
                                    if (dataGridView1.Rows[ka].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        devamSatir++;
                                    }
                                }

                                for (int la = 0; la < deppoSayisi; la++)
                                {
                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        devamSutun++;

                                    }

                                }
                                if (devamSutun != 1)
                                {
                                    devamSutun = 0; devamSatir = 0;
                                    #region Satır Güncelleme
                                    for (int m = 0; m < fabrikaSayisi; m++)
                                    {
                                        if (dataGridView1.Rows[m].DefaultCellStyle.BackColor != Color.RosyBrown)
                                        {
                                            for (int i = 0; i < deppoSayisi; i++)
                                            {
                                                if (enKucuk > int.Parse(dataGridView1.Rows[m].Cells[i].Value.ToString()) && dataGridView1.Columns[i].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                {
                                                    enKucuk = int.Parse(dataGridView1.Rows[m].Cells[i].Value.ToString());
                                                    enKucukSutun = i;
                                                    enDusukMaliyetSatir[m] = i;
                                                }
                                            }
                                            if (m < fabrikaSayisi)
                                            {
                                                if (enKucukSutun == 0)
                                                {
                                                    for (int la = 0; la < deppoSayisi; la++)
                                                    {
                                                        if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                        {
                                                            enKucukSutun = la; break;
                                                        }
                                                    }
                                                    for (int la = 0; la < deppoSayisi; la++)
                                                    {
                                                        if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                        {
                                                            if (la != enKucukSutun)
                                                            {
                                                                enBuyuk = int.Parse(dataGridView1.Rows[m].Cells[la].Value.ToString()); break;
                                                            }
                                                            else
                                                            {
                                                                enDusukMaliyetSatir[m] = la;
                                                            }
                                                        }
                                                    }


                                                }
                                                if (enKucukSutun != 0)
                                                {
                                                    for (int la = 0; la < deppoSayisi; la++)
                                                    {
                                                        if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown && la != enKucukSutun)
                                                        {
                                                            enBuyuk = int.Parse(dataGridView1.Rows[m].Cells[la].Value.ToString());
                                                            break;
                                                        }
                                                    }

                                                }
                                            }
                                            for (int i = 0; i < deppoSayisi; i++)
                                            {
                                                if (dataGridView1.Columns[i].DefaultCellStyle.BackColor != Color.RosyBrown && enBuyuk > int.Parse(dataGridView1.Rows[m].Cells[i].Value.ToString()) && enKucukSutun != i)
                                                {
                                                    enBuyuk = int.Parse(dataGridView1.Rows[m].Cells[i].Value.ToString());
                                                }
                                            }
                                            satirCezalari[m] = enBuyuk - enKucuk;
                                            if (m + 1 < fabrikaSayisi)
                                            {
                                                for (int la = 0; la < deppoSayisi; la++)
                                                {
                                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                    {
                                                        enKucuk = int.Parse(dataGridView1.Rows[m + 1].Cells[la].Value.ToString());
                                                        break;
                                                    }

                                                }

                                            }
                                            enKucukSutun = 0;
                                        }
                                        else
                                        {
                                            satirCezalari[m] = 0;
                                            if (m + 1 < fabrikaSayisi)
                                            {
                                                for (int la = 0; la < fabrikaSayisi; la++)
                                                {
                                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                    {
                                                        enKucuk = int.Parse(dataGridView1.Rows[m + 1].Cells[la].Value.ToString());
                                                        break;
                                                    }

                                                }
                                            }

                                            continue;
                                        }

                                    }

                                    #endregion


                                    #region ListBox Sutun
                                    listBoxSutunCezalari.Items.Clear();
                                    for (int i = 0; i < sutunCezalari.Length; i++)
                                    {
                                        listBoxSutunCezalari.Items.Add((i + 1) + "->" + sutunCezalari[i]);
                                    }
                                    #endregion

                                    #region ListBox Satır
                                    listBoxSatirCezalari.Items.Clear();
                                    for (int i = 0; i < satirCezalari.Length; i++)
                                    {
                                        listBoxSatirCezalari.Items.Add((i + 1) + "->" + satirCezalari[i]);
                                    }
                                    #endregion


                                    #region En Buyuk Satır  Cezası ne ve Hangi Satırda?
                                    enBuyukSatirCezasi = satirCezalari[0];
                                    hangiSatir = 0;
                                    for (int i = 0; i < 1; i++)
                                    {

                                        for (int k = 0; k < satirCezalari.Length; k++)
                                        {
                                            if (satirCezalari[k] > enBuyukSatirCezasi)
                                            {
                                                enBuyukSatirCezasi = satirCezalari[k];
                                                hangiSatir = k;
                                            }

                                        }

                                    }
                                    enBuyukSutunCezasi = sutunCezalari[0];
                                    hangiSutun = 0;
                                    for (int i = 0; i < 1; i++)
                                    {

                                        for (int k = 0; k < sutunCezalari.Length; k++)
                                        {
                                            if (sutunCezalari[k] > enBuyukSutunCezasi)
                                            {
                                                enBuyukSutunCezasi = sutunCezalari[k];
                                                hangiSutun = k;
                                            }

                                        }

                                    }
                                    #endregion

                                }
                                else
                                {
                                    devamSutun = 1; devamSatir = 1;
                                    for (int la = 0; la < deppoSayisi; la++)
                                    {
                                        if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                        {
                                            hangiSatir = 0;
                                        }

                                    }
                                }


                            }

                            if (devamSutun == 1)
                            {
                                for (int la = 0; la < talepDizisi.Length; la++)
                                {
                                    if (int.Parse(talepDizisi[la]) != 0)
                                    {
                                        for (int ka = 0; ka < arzDizisi.Length; ka++)
                                        {
                                            if (int.Parse(arzDizisi[ka]) != 0)
                                            {
                                                if (int.Parse(talepDizisi[la]) > int.Parse(arzDizisi[ka]))
                                                {
                                                    toplamMaliyet += int.Parse(arzDizisi[ka]) * int.Parse(dataGridView1.Rows[ka].Cells[la].Value.ToString());
                                                    int degisken = int.Parse(talepDizisi[la]) - int.Parse(arzDizisi[ka]);
                                                    talepDizisi[la] = degisken.ToString();
                                                    int degisken2 = 0;
                                                    arzDizisi[ka] = degisken2.ToString();
                                                }
                                                else
                                                {
                                                    toplamMaliyet += int.Parse(talepDizisi[la]) * int.Parse(dataGridView1.Rows[ka].Cells[la].Value.ToString());

                                                    int degisken = int.Parse(arzDizisi[ka]) - int.Parse(talepDizisi[la]);
                                                    arzDizisi[ka] = degisken.ToString();
                                                    int degisken2 = 0;
                                                    talepDizisi[la] = degisken2.ToString();
                                                }
                                            }
                                        }
                                    }

                                }
                                #region Matris Güncelleme
                                for (int j = 0; j < deppoSayisi; j++)
                                {
                                    //for (int i = fabrikaSayisi; i < fabrikaSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[i].Cells[j].Value = talepDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[fabrikaSayisi].Cells[j].Value = talepDizisi[j];
                                    continue;
                                }
                                for (int j = 0; j < fabrikaSayisi; j++)
                                {
                                    //for (int i = deppoSayisi; i < deppoSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[j].Cells[i].Value = arzDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[j].Cells[deppoSayisi].Value = arzDizisi[j];
                                    continue;
                                }
                                MessageBox.Show("Toplam Maliyet->" + toplamMaliyet); 
                                #endregion

                                break;
                            }

                        }
                        else
                        {
                            devamSatir = 0; devamSutun = 0;


                            if (int.Parse(talepDizisi[hangiSutun]) > int.Parse(arzDizisi[enDusukMaliyetSutun[hangiSutun]]))
                            {
                                toplamMaliyet += int.Parse(dataGridView1.Rows[enDusukMaliyetSutun[hangiSutun]].Cells[hangiSutun].Value.ToString()) * int.Parse(arzDizisi[enDusukMaliyetSutun[hangiSutun]]);
                                int degisken = int.Parse(talepDizisi[hangiSutun]) - int.Parse(arzDizisi[enDusukMaliyetSutun[hangiSutun]]);
                                talepDizisi[hangiSutun] = degisken.ToString();
                                int degisken2 = 0;
                                arzDizisi[enDusukMaliyetSutun[hangiSutun]] = degisken2.ToString();
                                satirCezalari[enDusukMaliyetSutun[hangiSutun]] = 0;


                                #region Matris Güncelleme
                                for (int j = 0; j < deppoSayisi; j++)
                                {
                                    //for (int i = fabrikaSayisi; i < fabrikaSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[i].Cells[j].Value = talepDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[fabrikaSayisi].Cells[j].Value = talepDizisi[j];
                                    continue;
                                }
                                for (int j = 0; j < fabrikaSayisi; j++)
                                {
                                    //for (int i = deppoSayisi; i < deppoSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[j].Cells[i].Value = arzDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[j].Cells[deppoSayisi].Value = arzDizisi[j];
                                    continue;
                                }
                                dataGridView1.Rows[enDusukMaliyetSutun[hangiSutun]].DefaultCellStyle.BackColor = Color.RosyBrown;
                                dataGridView1.Rows[enDusukMaliyetSutun[hangiSutun]].DefaultCellStyle.ForeColor = Color.White;

                                MessageBox.Show("Toplam Maliyet->" + toplamMaliyet);

                                #endregion
                                
                                
                                for (int la = 0; la < fabrikaSayisi; la++)
                                {
                                    if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        for (int ka = 0; ka < deppoSayisi; ka++)
                                        {
                                            if (dataGridView1.Columns[ka].DefaultCellStyle.BackColor != Color.RosyBrown)
                                            {
                                                enKucuk = int.Parse(dataGridView1.Rows[la].Cells[ka].Value.ToString());
                                                enBuyuk = int.Parse(dataGridView1.Rows[la].Cells[ka].Value.ToString());
                                                break;
                                            }
                                        }


                                        break;
                                    }
                                }


                                for (int la = 0; la < fabrikaSayisi; la++)
                                {
                                    if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        devamSatir++;
                                    }
                                }
                                for (int la = 0; la < deppoSayisi; la++)
                                {
                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        devamSutun++;
                                    }
                                }
                                if (devamSatir != 1)
                                {
                                    devamSatir = 0; devamSutun = 0;

                                    #region Sutun Güncelleme
                                    for (int m = 0; m < deppoSayisi; m++)
                                    {
                                        if (dataGridView1.Columns[m].DefaultCellStyle.BackColor != Color.RosyBrown)
                                        {
                                            for (int i = 0; i < fabrikaSayisi; i++)
                                            {
                                                if (enKucuk > int.Parse(dataGridView1.Rows[i].Cells[m].Value.ToString()) && dataGridView1.Rows[i].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                {
                                                    enKucuk = int.Parse(dataGridView1.Rows[i].Cells[m].Value.ToString());
                                                    enKucukSatir = i;
                                                    enDusukMaliyetSutun[m] = i;
                                                }

                                            }

                                            if (m < deppoSayisi)
                                            {
                                                if (enKucukSatir == 0)
                                                {
                                                    for (int la = 0; la < fabrikaSayisi; la++)
                                                    {
                                                        if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                        {
                                                            enKucukSatir = la; break;
                                                        }
                                                    }
                                                    for (int la = 0; la < fabrikaSayisi; la++)
                                                    {
                                                        if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                        {
                                                            if (la != enKucukSatir)
                                                            {
                                                                enBuyuk = int.Parse(dataGridView1.Rows[la].Cells[m].Value.ToString()); break;
                                                            }
                                                            else
                                                            {
                                                                enDusukMaliyetSutun[m] = la;
                                                            }
                                                        }
                                                    }
                                                }

                                                if (enKucukSatir != 0)
                                                {
                                                    for (int la = 0; la < fabrikaSayisi; la++)
                                                    {
                                                        if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown && la != enKucukSatir)
                                                        {
                                                            enBuyuk = int.Parse(dataGridView1.Rows[la].Cells[m].Value.ToString());
                                                            break;
                                                        }
                                                    }

                                                }

                                            }
                                            for (int i = 0; i < fabrikaSayisi; i++)
                                            {
                                                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor != Color.RosyBrown && enBuyuk > int.Parse(dataGridView1.Rows[i].Cells[m].Value.ToString()) && i != enKucukSatir)
                                                {
                                                    enBuyuk = int.Parse(dataGridView1.Rows[i].Cells[m].Value.ToString());
                                                }
                                            }

                                            sutunCezalari[m] = enBuyuk - enKucuk;




                                            if (m + 1 < deppoSayisi)
                                            {
                                                for (int la = 0; la < deppoSayisi; la++)
                                                {
                                                    if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                    {
                                                        enKucuk = int.Parse(dataGridView1.Rows[la].Cells[m + 1].Value.ToString());
                                                        break;
                                                    }

                                                }
                                            }

                                            enKucukSatir = 0;
                                        }
                                        else
                                        {
                                            sutunCezalari[m] = 0;
                                            if (m + 1 < deppoSayisi)
                                            {
                                                for (int la = 0; la < deppoSayisi; la++)
                                                {
                                                    if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                    {
                                                        enKucuk = int.Parse(dataGridView1.Rows[la].Cells[m + 1].Value.ToString());
                                                        break;
                                                    }

                                                }
                                            }

                                            continue;
                                        }


                                    }

                                    #endregion

                                    #region ListBox Sutun
                                    listBoxSutunCezalari.Items.Clear();
                                    for (int i = 0; i < sutunCezalari.Length; i++)
                                    {
                                        listBoxSutunCezalari.Items.Add((i + 1) + "->" + sutunCezalari[i]);
                                    }
                                    #endregion

                                    #region ListBox Satır
                                    listBoxSatirCezalari.Items.Clear();
                                    for (int i = 0; i < satirCezalari.Length; i++)
                                    {
                                        listBoxSatirCezalari.Items.Add((i + 1) + "->" + satirCezalari[i]);
                                    }
                                    #endregion


                                    #region En Buyuk Sutun Cezası ne ve Hangi Sutunda?
                                    enBuyukSutunCezasi = sutunCezalari[0];
                                    hangiSutun = 0;

                                    for (int k = 0; k < sutunCezalari.Length; k++)
                                    {
                                        if (sutunCezalari[k] > enBuyukSutunCezasi)
                                        {
                                            enBuyukSutunCezasi = sutunCezalari[k];
                                            hangiSutun = k;
                                        }

                                    }
                                    enBuyukSatirCezasi = satirCezalari[0];
                                    hangiSatir = 0;

                                    for (int k = 0; k < satirCezalari.Length; k++)
                                    {
                                        if (satirCezalari[k] > enBuyukSatirCezasi)
                                        {
                                            enBuyukSatirCezasi = satirCezalari[k];
                                            hangiSatir = k;
                                        }

                                    }
                                    #endregion

                                }
                                else
                                {
                                    devamSutun = 1;
                                    for (int la = 0; la < fabrikaSayisi; la++)
                                    {
                                        if (dataGridView1.Rows[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                        {
                                            hangiSutun = 0;
                                        }
                                    }
                                }


                            }


                            else
                            {
                                toplamMaliyet += int.Parse(dataGridView1.Rows[enDusukMaliyetSutun[hangiSutun]].Cells[hangiSutun].Value.ToString()) * int.Parse(talepDizisi[hangiSutun]);

                                int degisken = int.Parse(arzDizisi[enDusukMaliyetSutun[hangiSutun]]) - int.Parse(talepDizisi[hangiSutun]);
                                arzDizisi[enDusukMaliyetSutun[hangiSutun]] = degisken.ToString();
                                int degisken2 = 0;
                                talepDizisi[hangiSutun] = degisken2.ToString();

                                int degisken3 = hangiSutun;
                                sutunCezalari[hangiSutun] = 0;


                                #region Matris Güncelleme
                                for (int j = 0; j < deppoSayisi; j++)
                                {
                                    //for (int i = fabrikaSayisi; i < fabrikaSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[i].Cells[j].Value = talepDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[fabrikaSayisi].Cells[j].Value = talepDizisi[j];
                                    continue;
                                }
                                for (int j = 0; j < fabrikaSayisi; j++)
                                {
                                    //for (int i = deppoSayisi; i < deppoSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[j].Cells[i].Value = arzDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[j].Cells[deppoSayisi].Value = arzDizisi[j];
                                    continue;
                                }
                                dataGridView1.Columns[hangiSutun].DefaultCellStyle.BackColor = Color.RosyBrown;
                                dataGridView1.Columns[hangiSutun].DefaultCellStyle.ForeColor = Color.White;

                                MessageBox.Show("Toplam Maliyet->" + toplamMaliyet); 
                                #endregion

                                for (int la = 0; la < deppoSayisi; la++)
                                {
                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        for (int ka = 0; ka < fabrikaSayisi; ka++)
                                        {
                                            if (dataGridView1.Rows[ka].DefaultCellStyle.BackColor != Color.RosyBrown)
                                            {
                                                enKucuk = int.Parse(dataGridView1.Rows[ka].Cells[la].Value.ToString());
                                                enBuyuk = int.Parse(dataGridView1.Rows[ka].Cells[la].Value.ToString());
                                                break;
                                            }
                                        }
                                        break;
                                    }

                                }


                                for (int la = 0; la < deppoSayisi; la++)
                                {
                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        devamSutun++;
                                    }

                                }
                                for (int ka = 0; ka < fabrikaSayisi; ka++)
                                {
                                    if (dataGridView1.Rows[ka].DefaultCellStyle.BackColor != Color.RosyBrown)
                                    {
                                        devamSatir++;
                                    }
                                }
                                if (devamSutun != 1)
                                {


                                    devamSutun = 0; devamSatir = 0;


                                    #region Satır Güncelleme
                                    for (int m = 0; m < fabrikaSayisi; m++)
                                    {
                                        if (dataGridView1.Rows[m].DefaultCellStyle.BackColor != Color.RosyBrown)
                                        {
                                            for (int i = 0; i < deppoSayisi; i++)
                                            {
                                                if (enKucuk > int.Parse(dataGridView1.Rows[m].Cells[i].Value.ToString()) && dataGridView1.Columns[i].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                {
                                                    enKucuk = int.Parse(dataGridView1.Rows[m].Cells[i].Value.ToString());
                                                    enKucukSutun = i;
                                                    enDusukMaliyetSatir[m] = i;
                                                }
                                            }

                                            if (m < fabrikaSayisi)
                                            {
                                                if (enKucukSutun == 0)
                                                {
                                                    for (int la = 0; la < deppoSayisi; la++)
                                                    {
                                                        if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                        {
                                                            enKucukSutun = la; break;
                                                        }
                                                    }
                                                    for (int la = 0; la < deppoSayisi; la++)
                                                    {
                                                        if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                        {
                                                            if (la != enKucukSutun)
                                                            {
                                                                enBuyuk = int.Parse(dataGridView1.Rows[m].Cells[la].Value.ToString()); break;
                                                            }
                                                            else
                                                            {
                                                                enDusukMaliyetSatir[m] = la;
                                                            }
                                                        }
                                                    }
                                                }

                                                if (enKucukSutun != 0)
                                                {
                                                    for (int la = 0; la < deppoSayisi; la++)
                                                    {
                                                        if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown && la != enKucukSutun)
                                                        {
                                                            enBuyuk = int.Parse(dataGridView1.Rows[m].Cells[la].Value.ToString());
                                                            break;
                                                        }
                                                    }
                                                }
                                            }
                                            for (int i = 0; i < deppoSayisi; i++)
                                            {
                                                if (dataGridView1.Columns[i].DefaultCellStyle.BackColor != Color.RosyBrown && enBuyuk > int.Parse(dataGridView1.Rows[m].Cells[i].Value.ToString()) && i != enKucukSutun)
                                                {
                                                    enBuyuk = int.Parse(dataGridView1.Rows[m].Cells[i].Value.ToString());
                                                }
                                            }
                                            satirCezalari[m] = enBuyuk - enKucuk;


                                            if (m + 1 < fabrikaSayisi)
                                            {
                                                for (int la = 0; la < fabrikaSayisi; la++)
                                                {
                                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                    {
                                                        enKucuk = int.Parse(dataGridView1.Rows[m + 1].Cells[la].Value.ToString());
                                                        break;
                                                    }

                                                }
                                            }

                                            enKucukSutun = 0;

                                        }

                                        else
                                        {
                                            satirCezalari[m] = 0;
                                            if (m + 1 < fabrikaSayisi)
                                            {
                                                for (int la = 0; la < fabrikaSayisi; la++)
                                                {
                                                    if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                                    {
                                                        enKucuk = int.Parse(dataGridView1.Rows[m + 1].Cells[la].Value.ToString());
                                                        break;
                                                    }

                                                }
                                            }

                                            continue;
                                        }

                                    }

                                    #endregion


                                    #region ListBox Sutun
                                    listBoxSutunCezalari.Items.Clear();
                                    for (int i = 0; i < sutunCezalari.Length; i++)
                                    {
                                        listBoxSutunCezalari.Items.Add((i + 1) + "->" + sutunCezalari[i]);
                                    }
                                    #endregion

                                    #region ListBox Satır
                                    listBoxSatirCezalari.Items.Clear();
                                    for (int i = 0; i < satirCezalari.Length; i++)
                                    {
                                        listBoxSatirCezalari.Items.Add((i + 1) + "->" + satirCezalari[i]);
                                    }
                                    #endregion




                                    #region En Buyuk Sutun Cezası ne ve Hangi Sutunda?
                                    enBuyukSatirCezasi = satirCezalari[0];
                                    hangiSatir = 0;
                                    for (int k = 0; k < satirCezalari.Length; k++)
                                    {
                                        if (satirCezalari[k] > enBuyukSatirCezasi)
                                        {
                                            enBuyukSatirCezasi = satirCezalari[k];
                                            hangiSatir = k;
                                        }
                                    }

                                    enBuyukSutunCezasi = sutunCezalari[0];
                                    hangiSutun = 0;
                                    for (int k = 0; k < sutunCezalari.Length; k++)
                                    {
                                        if (sutunCezalari[k] > enBuyukSutunCezasi)
                                        {
                                            enBuyukSutunCezasi = sutunCezalari[k];
                                            hangiSutun = k;
                                        }
                                    }

                                    #endregion

                                }
                                else
                                {

                                    devamSutun = 1;
                                    for (int la = 0; la < deppoSayisi; la++)
                                    {
                                        if (dataGridView1.Columns[la].DefaultCellStyle.BackColor != Color.RosyBrown)
                                        {
                                            hangiSatir = 0;
                                        }

                                    }
                                }
                            }


                            if (devamSutun == 1)
                            {
                                for (int la = 0; la < talepDizisi.Length; la++)
                                {
                                    if (int.Parse(talepDizisi[la]) != 0)
                                    {
                                        for (int ka = 0; ka < arzDizisi.Length; ka++)
                                        {
                                            if (int.Parse(arzDizisi[ka]) != 0)
                                            {
                                                if (int.Parse(talepDizisi[la]) > int.Parse(arzDizisi[ka]))
                                                {
                                                    toplamMaliyet += int.Parse(arzDizisi[ka]) * int.Parse(dataGridView1.Rows[ka].Cells[la].Value.ToString());
                                                    int degisken = int.Parse(talepDizisi[la]) - int.Parse(arzDizisi[ka]);
                                                    talepDizisi[la] = degisken.ToString();
                                                    int degisken2 = 0;
                                                    arzDizisi[ka] = degisken2.ToString();
                                                }
                                                else
                                                {
                                                    toplamMaliyet += int.Parse(talepDizisi[la]) * int.Parse(dataGridView1.Rows[ka].Cells[la].Value.ToString());

                                                    int degisken = int.Parse(arzDizisi[ka]) - int.Parse(talepDizisi[la]);
                                                    arzDizisi[ka] = degisken.ToString();
                                                    int degisken2 = 0;
                                                    talepDizisi[la] = degisken2.ToString();
                                                }
                                            }
                                        }
                                    }
                                }

                                #region Matris Güncelleme
                                for (int j = 0; j < deppoSayisi; j++)
                                {
                                    //for (int i = fabrikaSayisi; i < fabrikaSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[i].Cells[j].Value = talepDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[fabrikaSayisi].Cells[j].Value = talepDizisi[j];
                                    continue;
                                }
                                for (int j = 0; j < fabrikaSayisi; j++)
                                {
                                    //for (int i = deppoSayisi; i < deppoSayisi + 1; i++)
                                    //{
                                    //    dataGridView1.Rows[j].Cells[i].Value = arzDizisi[j];
                                    //    break;
                                    //}
                                    dataGridView1.Rows[j].Cells[deppoSayisi].Value = arzDizisi[j];
                                    continue;
                                }
                                MessageBox.Show("Toplam Maliyet->" + toplamMaliyet); 
                                #endregion

                                break;
                            }
                        }
                    }


                    #region Maliyet Yazdırma
                    labelMaliyet.Text = toplamMaliyet.ToString();


                    if (toplamTalep > toplamArz)
                    {
                        dataGridView1.Rows[fabrikaSayisi + 1].Cells[deppoSayisi].Value = toplamMaliyet;
                    }
                    else if (toplamArz > toplamTalep)
                    {
                        dataGridView1.Rows[fabrikaSayisi].Cells[deppoSayisi + 1].Value = toplamMaliyet;
                    }
                    else
                    {
                        dataGridView1.Rows[fabrikaSayisi].Cells[deppoSayisi].Value = toplamMaliyet;
                    }

                    #endregion


                }
                else
                {
                    MessageBox.Show("-verileri lutfen giriniz-", "UYARI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);

                }
               
            }

        }

        private void textBoxDepoSayisi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void textBoxFabrikaSayisi_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void panel_baslik_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel_baslik_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel_baslik_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void textBoxDepoSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {  e.Handled = true; }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }

        }

        private void textBoxFabrikaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.ColumnIndex == 1) // 1 should be your column index
            //{
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("-Lütfen sayı giriniz-");
                }
                else
                {
                    // the input is numeric 
                }
           // }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
