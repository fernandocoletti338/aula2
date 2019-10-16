$(document).ready(

    function () {
        $('input[type="button"]').click(

            function () {
                var real = $('input[name="real"]').val();
                $('input[name="dolar"]').val(real / 4.15);

       
                if (real <= 0) {
                    alert("Valor informado não é compativel para converter.");
                }
            })
    });