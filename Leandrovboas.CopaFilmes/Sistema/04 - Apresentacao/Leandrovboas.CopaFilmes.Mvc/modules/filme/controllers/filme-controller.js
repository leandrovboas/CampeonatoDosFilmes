(function (app) {
    app.controller('FilmeCtrl', FilmeCtrl);
    FilmeCtrl.$inject = ['$scope', 'filmeService'];
    function FilmeCtrl($scope, filmeService) {
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
            if (vm.filmesSelecionados.length !== 16) toastr.error("Selecione 16 filmes para gerar o campeonato", "Parametro Invalido", );

            toastr.success("Gerando Campeonato ........", "Gerar Campeonato", );
        }

        vm.selecionar = (filme) => {
            if (!filme.Selecionado) {
                adicionarFilme(filme);
            } else {
                removerFilme(filme);
            }
        }
    }
})(angular.module('FilmeApp'));