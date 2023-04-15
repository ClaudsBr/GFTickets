var endereco = "https://localhost:5001/Compra/Evento/";
var evento;
//var compra = [];
var __total__ = 0;

$("#posvenda").hide();
atualizarCompra();

function atualizarCompra(){
    $("#total").html(__total__);
}

function preencherForm(dadosEvento){
    $("#campoNome").val(dadosEvento.nome);    
    $("#campoLocal").val(dadosEvento.localDoEvento.nome);     
    $("#campoPreco").val(dadosEvento.valorDoIngresso);
}

$("#confirmarCompraBTN").click(function(){
    if(__total__ <= 0){
        alert("Compra Invalida! \nNenhum ingresso adicionado ao carrinho");
        return;
    }
    alert("Compra Efetuada com Sucesso!");
    $("#posvenda").show();
    $("#prevenda").hide();
});

function limparForm(){
    $("#campoNome").val("");    
    $("#campoLocal").val("");     
    $("#campoPreco").val("");
    $("#campoQuantidade").val("");
}

function voltarHome(){
    window.location.assign("https://localhost:5001/Home/Index");
}

function adicionarNoCarrinho(e, q){
    var eventoTemp = {};
    Object.assign(eventoTemp, evento);
    var venda = {evento: eventoTemp, quantidade: q, subtotal: eventoTemp.valorDoIngresso * q}
    __total__ += venda.subtotal;
    atualizarCompra();
    //compra.push(eventoTemp);
    $("#compras").append(`<tr>
        <td>${e.id}</td>
        <td>${e.nome}</td>
        <td>${q}</td>
        <td>R$ ${e.valorDoIngresso},00</td>
        <td>R$ ${e.valorDoIngresso * q},00</td>
        
    </tr>`);
}




$("#produtoForm").on("submit", function(event){
    event.preventDefault();
    var eventoTabela = evento;
    var qtd = $("#campoQuantidade").val();
    console.log(eventoTabela);
    console.log(qtd);
    adicionarNoCarrinho(eventoTabela, qtd);
    
    //limparForm();
});

$("#pesquisar").click(function(){
    var codProduto = $("#codProduto").val();
    var enderecoTemp = endereco+codProduto
    $.post(enderecoTemp, function(dados, status){
        evento = dados;
        preencherForm(evento);
        console.log(evento); 
    }).fail(function(){
        alert("Este Evento não existe");
    });
});

$("#fecharModal").click(function(){
    voltarHome();
});