(function (app) {
    app.controller('filmeCtrl', filmeCtrl);
    filmeCtrl.$inject = ['$scope', 'filmeService'];
    function FilmeCtrl($scope, filmeService) {
        let vm = this;
        const menssagemErro = 'Um Erro ocorreu na rotina, por favor consulte o responsável pelos sistemas';

        function criarListagemParametros() {
            self.paramsParametros = new NgTableParams({
                page: 1
                , count: 10
                , sorting: {}
                , filter: {
                    IdDisciplina: '',
                    DescricaoEtapa: ''
                }

            }, {
                    counts: [],
                    getData: function ($defer, params) {
                        var orderedData = params.sorting() ? $filter('orderBy')(self.parametros, params.orderBy(), false) : self.parametros;
                        var filter = angular.copy(params.filter());

                        for (var key in filter) {
                            if (filter[key] == '' || filter[key] == null) {
                                delete filter[key];
                            }
                        }

                        for (var key in self.filtrosParametro) {

                            if (key != "Disciplina" && key != "Etapa") {
                                if (self.filtrosParametro[key][key].id == 'calendar') {
                                    if (angular.isDefined(filter[key])) {
                                        orderedData = $filter('DateFilter')(orderedData, filter[key], key);
                                        delete filter[key];
                                    }
                                }
                            }
                            else {
                                //orderedData = $filter('DateFilter')(orderedData, filter[key], true, key);
                                //delete filter[key];
                            }

                        }

                        orderedData = filter ? $filter('filter')(orderedData, filter) : orderedData;

                        self.total = 0;

                        if (orderedData != undefined) {
                            params.total(orderedData.length);
                            self.total = orderedData.length;
                            $defer.resolve(orderedData.slice((params.page() - 1) * params.count(), params.page() * params.count()));
                        }
                    }
                });
        }
        criarListagemParametros();
    };
})(angular.module('filmeApp'));