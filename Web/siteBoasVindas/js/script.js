$(document).ready(

    function () {

        $('input[type="button"]').click(
            function () {
                /*obtemos o nome da pessoa*/
                var nome = $('input[name="nome"]').val();

                alert("Olá " + nome + " Seja bem vindo ao paraíso ");

            })
    });