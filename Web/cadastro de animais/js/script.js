var animal = { Nome: "Taila", Idade: "8", Raca: "Pit bull/Boxer", Coloracao: "Preto/Branco" }

$(document).ready(
    function () {

        $('input[name="Nome"]').val(animal.Nome);
        $('input[name="Idade"]').val(animal.Idade);
        $('input[name="Raca"]').val(animal.Raca);
        $('input[name="Coloracao"]').val(animal.Coloracao);

        $('button[name="Salvar"]').click(function () {
            animal.Nome = $('input[name="Nome"]').val();
            animal.Idade = $('input[name="Idade"]').val();
            animal.Raca = $('input[name="Raca"]').val();
            animal.Coloracao = $('input[name="Coloracao"]').val();
            //Limpa a tela assim que clicar no botão salvar (lembrando da função lá em baixo limparTela)
            limparTela();
        });

        

        $('button[name="Mostrar"]').click(function () {
            alert("Nome: " + animal.Nome
                + "\nIdade: " + animal.Idade
                + "\nRaca: " + animal.Raca
                + "\nColoracao: " + animal.Coloracao);
        });
    }
);
function limparTela() {
    //obtemos todos os campos do tipo input
    var meusInputs = $('input[type="text"]');
    //loop para tds os campos
    //limpamos o valor dos campos
    meusInputs.val("");

}