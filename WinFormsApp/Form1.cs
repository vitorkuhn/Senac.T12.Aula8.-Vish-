using System.Runtime.InteropServices;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        // variaveis
        private const int MOUSEEVENT_LEFTDOWN = 0x0002;
        private const int MOUSEEVENT_LEFTUP = 0x0004;
        // metodo que execeuta o evento de click
        [DllImport("user32.dll", CharSet = CharSet.Auto,CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        //gerar as posicoes aleatorias
        private Random random = new Random();

        //movimento aleatorio do mouse
        
        private void MoverCursor()
        {
            //largura da tela
            int larguraTela = Screen.PrimaryScreen.Bounds.Width;
            //altura da tela
            int alturaTela = Screen.PrimaryScreen.Bounds.Height;
            //posicaoXAleatoria
            int posicaoXAleatoria = random.Next(larguraTela);
            //posicaoYAleatoria
            int posicaoYAleatoria = random.Next(alturaTela);
            //posicao do curor
            Cursor.Position = new Point(posicaoYAleatoria, posicaoXAleatoria);

        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
