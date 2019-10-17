/*ao carregar nosso site por completo executa o conteudo do $(document).ready*/
$(document).ready(
    function () {
        //informamos que no botão do click ele ira chamar nosso alerta
        $('button[name="btnboasvindas"]').click(function () {
            /*aqui obtemos o valor digitado pelo usuario*/
            var nomeusuario = $('input[name="nomeusuario"]').val();
            /*apresentamos nosso alerta de boas vindas*/
            $('span[name="usuariotext"]').text(nomeusuario);

        });
        
    }
);

$(document).on('keypress', function (e) {
    if (e.keyCode === 13) {
        $('button[name="btnboasvindas"]').click();
    }
});