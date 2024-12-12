private void btnSemaforo1Verde_Click(object sender, EventArgs e)
{
    // Defina as imagens visíveis de acordo com o estado
    pbSemaforo1Verde.Visible = true;
    pbSemaforo1Amarelo.Visible = false;
    pbSemaforo1Vermelho.Visible = false;
    semaforo1 = 0b00000001; // Ativa a luz verde no semáforo 1
    AtualizarInterface();  // Atualiza a interface
}
