using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;

namespace CotacaoDolarHG
{
    public partial class FrmCotacaoDolar : Form
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string sUrlDolar = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=2c6a2eb2";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(sUrlDolar).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        Func<int, string> FormatCurrencyJsonString = delegate(int itipo)
                        {
                            decimal valor;
                            string format = "{0:C}";
                            switch (itipo)
                            {
                                case 1:
                                    valor = market.Currency.Buy;
                                    break;
                                case 2:
                                    valor = market.Currency.Sell;
                                    break;
                                case 3:
                                    valor = market.Currency.Variation / 100;
                                    format = "{0:P}";
                                    break;

                                default:
                                    return "";
                            }

                            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), format, valor);
                        };

                        this.lblValorCompra.Text = FormatCurrencyJsonString(1);
                        this.lblValorVenda.Text = FormatCurrencyJsonString(2);
                        this.lblValorVariacao.Text = FormatCurrencyJsonString(3);
                    }
                    else
                        LimpaCampos();
                }
            }
            catch (Exception ex)
            {
                LimpaCampos();
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaCampos()
        {
            this.lblValorCompra.Text = "-";
            this.lblValorVenda.Text = "-";
            this.lblValorVariacao.Text = "-";
        }
    }
}
