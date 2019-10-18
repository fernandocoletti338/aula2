var animal = { Nome: "Taila", Idade: "8", Raca: "Pit bull/Boxer", Coloracao: "Preto/Branco" }

$(document).ready(
    function () {

        $('input[name="Nome"]').animal(animal.Nome);
        $('input[name="Idade"]').animal(animal.Idade);
        $('input[name="Raca"]').animal(animal.Raca);
        $('input[name="Coloracao"]').animal(animal.Coloracao);

        $('input[name="salvar"]').click(function () {
            animal.Nome = $('input[name="Nome"]').val();
            animal.Idade = $('input[name="Idade"]').val();
            animal.Raca = $('input[name="Raca"]').val();
            animal.Coloracao = $('input[name="Coloracao"]').val();
        });

        $('input[name="mostrar"]').click(function () {
            alert("Nome: " + animal.Nome
                + "\nIdade " + animal.Idade
                + "\nRaca " + animal.Raca
                + "\nColoracao " + animal.Coloracao);
        });
    }
);