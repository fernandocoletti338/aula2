var bike = { Marca: "Caloi", Valor: "1200.00", Peso: "15.00" }

$(document).ready(
    function () {

        $('input[name="Marca"]').val(bike.Marca);
        $('input[name="Valor"]').val(bike.Valor);
        $('input[name="Peso"]').val(bike.Peso);
        

        $('button[name="Salvar"]').click(function () {
            bike.Marca = $('input[name="Marca"]').val();
            bike.Valor = $('input[name="Valor"]').val();
            bike.Peso = $('input[name="Peso"]').val();          
        });

        $('button[name="Mostrar"]').click(function () {
            alert("Marca: " + bike.Marca
                + "\nValor: R$ " + bike.Valor
                + "\nPeso: Kg " + bike.Peso);               
        });
    }
);