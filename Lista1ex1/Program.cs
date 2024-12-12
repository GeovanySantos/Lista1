private void btnSemaforo1Verde_Click(object sender, EventArgs e)
{
    semaforo1 = 0b00000001; // Ativa a luz verde no semáforo 1
    AtualizarInterface();  // Atualiza a interface com os novos estados
}
