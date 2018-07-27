(function (app) {
    app.controller('CampeonatoCtrl', CampeonatoCtrl);
    CampeonatoCtrl.$inject = ['$scope', '$window', 'filmeService'];
    function CampeonatoCtrl($scope, $window, filmeService) {
        const menssagemErro = 'Um Erro ocorreu na rotina, por favor consulte o responsável pelos sistemas';

        let vm = this;
        vm.listaFilmes = [];
    }
})(angular.module('CampeonatoCtrl'));