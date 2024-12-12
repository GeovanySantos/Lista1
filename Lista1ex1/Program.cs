using System;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {
        private byte semaforo1;
        private byte semaforo2;

        public Form1()
        {
            InitializeComponent();
            semaforo1 = 0b00000000; // Inicialmente desligado
            semaforo2 = 0b00000000;
            AtualizarInterface();
        }

        // Métodos para Semáforo 1
        private void btnSemaforo1Verde_Click(object sender, EventArgs e)
        {
            semaforo1 = 0b00000001; // Bit 0 para Verde
            AtualizarInterface();
        }

        private void btnSemaforo1Amarelo_Click(object sender, EventArgs e)
        {
            semaforo1 = 0b00000010; // Bit 1 para Amarelo
            AtualizarInterface();
        }

        private void btnSemaforo1Vermelho_Click(object sender, EventArgs e)
        {
            semaforo1 = 0b00000100; // Bit 2 para Vermelho
            AtualizarInterface();
        }

        // Métodos para Semáforo 2
        private void btnSemaforo2Verde_Click(object sender, EventArgs e)
        {
            semaforo2 = 0b00000001; // Bit 0 para Verde
            AtualizarInterface();
        }

        private void btnSemaforo2Amarelo_Click(object sender, EventArgs e)
        {
            semaforo2 = 0b00000010; // Bit 1 para Amarelo
            AtualizarInterface();
        }

        private void btnSemaforo2Vermelho_Click(object sender, EventArgs e)
        {
            semaforo2 = 0b00000100; // Bit 2 para Vermelho
            AtualizarInterface();
        }

        private void AtualizarInterface()
        {
            // Atualizar a interface gráfica com os valores dos bits
            lblSemaforo1Bits.Text = Convert.ToString(semaforo1, 2).PadLeft(8, '0');
            lblSemaforo2Bits.Text = Convert.ToString(semaforo2, 2).PadLeft(8, '0');

            // Exemplo de controle visual (reset)
            pbSemaforo1Verde.BackColor = (semaforo1 & 0b00000001) != 0 ? Color.Green : SystemColors.Control;
            pbSemaforo1Amarelo.BackColor = (semaforo1 & 0b00000010) != 0 ? Color.Yellow : SystemColors.Control;
            pbSemaforo1Vermelho.BackColor = (semaforo1 & 0b00000100) != 0 ? Color.Red : SystemColors.Control;

            pbSemaforo2Verde.BackColor = (semaforo2 & 0b00000001) != 0 ? Color.Green : SystemColors.Control;
            pbSemaforo2Amarelo.BackColor = (semaforo2 & 0b00000010) != 0 ? Color.Yellow : SystemColors.Control;
            pbSemaforo2Vermelho.BackColor = (semaforo2 & 0b00000100) != 0 ? Color.Red : SystemColors.Control;
        }
    }
}
