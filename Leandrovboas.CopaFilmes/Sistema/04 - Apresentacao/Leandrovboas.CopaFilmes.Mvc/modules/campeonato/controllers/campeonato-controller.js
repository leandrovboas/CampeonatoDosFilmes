(function (app) {
    app.controller('CampeonatoCtrl', CampeonatoCtrl);
    CampeonatoCtrl.$inject = ['$scope', 'CampeonatoService'];
    function CampeonatoCtrl($scope, CampeonatoService) {
        const menssagemErro = 'Um Erro ocorreu na rotina, por favor consulte o responsável pelos sistemas';

        let vm = this;
        vm.listaFilmes = undefined;
        vm.ocultarTela = true;
        vm.visualizarJsos = false;
        vm.historicoJson = undefined;

        vm.inicialCampeonato = () => {
            vm.listaFilmes = JSON.parse(sessionStorage.filmes);

            CampeonatoService.IniciarCampeonato(vm.listaFilmes)
                .then(function (data) {
                    if (data.status === 200) {
                        vm.resultadoCampeonato = data.data;
                        vm.ocultarTela = false;
                    } else {
                        vm.resultadoCampeonato = undefined;
                        vm.ocultarTela = true;
                        toastr.error(menssagemErro);
                    }
                });
        };

        vm.exibirJson = () => {
            if (vm.visualizarJsos) {
                vm.visualizarJsos = false;
            }
            else {
                vm.visualizarJsos = true;
            }
            vm.historicoJson = JSON.stringify(vm.resultadoCampeonato);
        }
    }
})(angular.module('CampeonatoApp'));