

$(document).ready(
    function () {
        /*set interval executa a cada 100ms*/
       atualizaData();  
    });

/*criamos nossa primeira fun��o*/ 
function atualizaData() {
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
    
}