(function (app) {
    app.controller('FilmeCtrl', FilmeCtrl);
    FilmeCtrl.$inject = ['$scope', '$http', 'filmeService', 'CampeonatoService'];
    function FilmeCtrl($scope, $http, filmeService, CampeonatoService) {
        const menssagemErro = 'Um Erro ocorreu na rotina, por favor consulte o responsável pelos sistemas';

        let vm = this;
        vm.listaFilmes = [];
        vm.filmesSelecionados = [];
        vm.quantidadeFilmesSelecionar = 16;

        let adicionarFilme = (filme) => {
            filme.Selecionado = true;
            vm.filmesSelecionados.push(filme);
        };

        let removerFilme = (filme) => {
            filme.Selecionado = false;
            var index = vm.filmesSelecionados.indexOf(filme);
            vm.filmesSelecionados.splice(index, 1);
        };

        vm.carregarFilmes = () => {
            filmeService.getFilmes()
                .then(function (data) {
                    if (data.status === 200) {
                        vm.listaFilmes = data.data;
                    } else {
                        vm.listaFilmes = [];
                        toastr.error(menssagemErro);
                    }
            });
        };

        vm.gerarCampeonato = () => {
            if (vm.filmesSelecionados.length !== 16) { toastr.error("Selecione 16 filmes para gerar o campeonato", "Parametro Invalido"); return;};

            //$http.defaults.headers.post["Content-Type"] = "application/x-www-form-urlencoded";

            $http({
                url: '/Campeonato/index',
                method: "POST",
                data: { 'filmes': vm.filmesSelecionados }
            })


            CampeonatoService.enviarFilmes(vm.filmesSelecionados);
        }

        vm.selecionar = (filme) => {
            if (!filme. Selecionado && vm.filmesSelecionados.length == vm.quantidadeFilmesSelecionar) {
                toastr.warning("Já estamos com os " + vm.quantidadeFilmesSelecionar + " filmes para iniciar o campeonato.");
                return;
            }
            if (!filme.Selecionado) { adicionarFilme(filme); }
            else { removerFilme(filme); }
        }
    }
})(angular.module('FilmeApp'));