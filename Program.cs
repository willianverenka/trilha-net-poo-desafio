using DesafioPOO.Models;
using FluentAssertions;
using Xunit;

namespace DesafioPOO
{
    public class SmartphoneTest
    {
        private Iphone _iphone;
        private Nokia _nokia;
        public SmartphoneTest()
        {
            _iphone = new Iphone("5511123456789", "X", "12345678910", 6);
            _nokia = new Nokia("5511987654321", "G21", "10987654321", 6);
        }
        [Fact]
        public void Iphone_Construtor_DeveInicializarCorretamente()
        {
            _iphone.Numero.Should().Be("5511123456789");
            _iphone.Modelo.Should().Be("X");
            _iphone.Imei.Should().Be("12345678910");
            _iphone.Memoria.Should().Be(6);

        }
        [Fact]
        public void Iphone_Ligar_DevePrintarMensagemCorreta()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _iphone.Ligar();
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

            string result = stringWriter.ToString().Replace("\r", "").Replace("\n", ""); ;

            result.Should().Be("Ligando...");
        }
        [Fact]
        public void Iphone_ReceberLigacao_DevePrintarMensagemCorreta()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _iphone.ReceberLigacao();
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

            string result = stringWriter.ToString().Replace("\r", "").Replace("\n", "");

            result.Should().Be("Recebendo ligação...");
        }
        [Theory]
        [InlineData("Facebook")]
        [InlineData("Instagram")]
        [InlineData("Whatsapp")]
        public void Iphone_InstalarAplicativo_DevePrintarMensagemCorreta(string nomeApp)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _iphone.InstalarAplicativo(nomeApp);
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

            string result = stringWriter.ToString().Replace("\r", "").Replace("\n", "");

            result.Should().Be($"Instalando aplicativo...{nomeApp} instalado no iPhone {_iphone.Modelo} com sucesso!");
        }
        [Fact]
        public void Nokia_Construtor_DeveInicializarCorretamente()
        {
            _nokia.Numero.Should().Be("5511987654321");
            _nokia.Modelo.Should().Be("G21");
            _nokia.Imei.Should().Be("10987654321");
            _nokia.Memoria.Should().Be(6);
        }
        [Fact]
        public void Nokia_Ligar_DevePrintarMensagemCorreta()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _nokia.Ligar();
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

            string result = stringWriter.ToString().Replace("\r", "").Replace("\n", ""); ;

            result.Should().Be("Ligando...");
        }
        [Fact]
        public void Nokia_ReceberLigacao_DevePrintarMensagemCorreta()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _nokia.ReceberLigacao();
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

            string result = stringWriter.ToString().Replace("\r", "").Replace("\n", ""); ;

            result.Should().Be("Recebendo ligação...");
        }
        [Theory]
        [InlineData("Facebook")]
        [InlineData("Instagram")]
        [InlineData("Whatsapp")]
        public void Nokia_InstalarAplicativo_DevePrintarMensagemCorreta(string nomeApp)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            _nokia.InstalarAplicativo(nomeApp);
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

            string result = stringWriter.ToString().Replace("\r", "").Replace("\n", ""); ;

            result.Should().Be($"Instalando aplicativo...{nomeApp} instalado no Nokia {_nokia.Modelo} com sucesso!");
        }
    }
}
