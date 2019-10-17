/*ao carregar nosso site por completo executa o conteudo do $(document).ready*/
$(document).ready(
    function () {
        //informamos que no botão do click ele ira chamar nosso alerta
        $('input[name="btnconverter"]').click(function () {

            var valordolar = 4.16;
            var valorreal = $('input[name="valorreal"]').val()
                .replace(".", "")
                .replace(",", ".");

            var convercao = valorreal / valordolar;

            $('input[name="valordolar"]').val(convercao);
            

        });
        //colocamos a mask em nosso campo 999.999,99
        $('input[name="valorreal"]').mask("000.000,00");
        
    }
);

$(document).on('keypress', function (e) {
    if (e.keyCode === 13) {
        $('input[name="btnconverter"]').click();
    }
});