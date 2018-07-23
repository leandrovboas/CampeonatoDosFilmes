(function (app) {
    app.controller('FilmeCtrl', FilmeCtrl);
    FilmeCtrl.$inject = ['$scope', 'filmeService'];
    function FilmeCtrl($scope, filmeService) {
        let vm = this;
        vm.listaFilmes = [];
        vm.filmesSelecionados = [];
        vm.quantidadeFilmesSelecionar = 16;
        vm.menssagemErro = 'Um Erro ocorreu na rotina, por favor consulte o responsável pelos sistemas';

        function criarListagemParametros() {
        }
        criarListagemParametros();
    }
})(angular.module('FilmeApp'));