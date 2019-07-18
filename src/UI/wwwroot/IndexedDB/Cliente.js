
<script src="~/js/jquery.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>
    <link href="~/css/font-awesome.min.css" rel="stylesheet" />

    <script type="text/javascript">
        $(document).ready(function () {
            window.indexedDB = window.indexedDB || window.mozIndexedDB || window.webkitIndexedDB || window.msIndexedDB;
        var request, db;
        if (!window.indexedDB) {
            console.log("Seu navegador não suporta o recurso HTML5 IndexedDB");
        }
        else {
            request = window.indexedDB.open("D5", 1);
        request.onerror = function (event) {
            console.log("Erro ao abrir o banco de dados", event);
        }

            request.onupgradeneeded = function (event) {
            console.log("Atualizando");
        db = event.target.result;
                var objectStore = db.createObjectStore("Cliente", {keyPath: "id", autoIncrement: true });
    };
            request.onsuccess = function (event) {
            console.log("Banco de dados aberto com sucesso");
        db = event.target.result;
    }
};

        $("#addBtn").click(function () {
            var Nome = $("#Nome").val();
        var Contato = $("#Contato").val();
        var Documento = $("#Documento").val();
        var Celular = $("#Celular").val();
        var Telefone = $("#Telefone").val();
        var Cep = $("#Cep").val();
        var Endereco = $("#Endereco").val();
        var Complemento = $("#Complemento").val();
        var Bairro = $("#Bairro").val();
        var Cidade = $("#Cidade").val();
        var Estado = $("#Estado").val();

        var transaction = db.transaction(["Cliente"], "readwrite");
            transaction.oncomplete = function (event) {
            console.log("Sucesso :)");
        $("#result").html("Adicionado com Sucesso");
    };
            transaction.onerror = function (event) {
            console.log("Erro :(");
        $("#result").html("Erro ao Adicionar");
    };

    var objectStore = transaction.objectStore("Cliente");
            objectStore.add({Nome: Nome, Contato: Contato, Documento: Documento, Celular: Celular, Telefone: Telefone, Cep: Cep, Endereco: Endereco, Complemento: Complemento, Bairro: Bairro, Cidade: Cidade, Estado: Estado });

        $('#content').html("");
        let body = '';
        body = 'Adicionado dados digitados.';
        $("#content").append(body);
        $("#myModal").modal();
            $("#myModal").modal({keyboard: false });
        $("#myModal").modal('show');
        return false;
    });

});
</script>

<script>
        function ClientePostar() {
        var json = {"numero": _numero, "produtoId": _produtoId, "DataEntrega": _DataEntrega, "VendedorId": _VendedorId, "ClienteId": _ClienteId, "DataPedido": _DataPedido, "quantidade": _quantidade, "observacao": _observacao };
        $.ajax({
            type: "POST",
        url: 'Pedido/post',
        data: JSON.stringify(json),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        cache: false,

            beforeSend: function (xhr) {
            xhr.setRequestHeader("Accept", "application/json");
        xhr.setRequestHeader("Content-Type", "application/json");
    },
            success: function (data) {
            //aqui podemos ver o retorno do json
            console.log(data);
        },
    });
}
</script>

