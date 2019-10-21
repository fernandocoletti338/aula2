
$(document).ready(
    function () {
        // executa ao clicar no bot�o
        $('input[type="button"]').click(

            function () {

                var ncep = $('input[name="cep"]').val();

                $.get("https://viacep.com.br/ws/" + ncep + "/json/", function (data, status) {

                    if (data.erro) {
                        alert("Cep inv�lido!");
                        return false;
                    }

                    $('input[name="logradouro"]').val(data.logradouro);
                    $('input[name="bairro"]').val(data.bairro);
                    $('input[name="localidade"]').val(data.localidade);
                    $('input[name="uf"]').val(data.uf);


                });
            }
        );
    }
);
