(function (app) {
    'use strict';
    app.factory('CampeonatoService', CampeonatoService);
    CampeonatoService.$inject = ['$http'];

    //function CampeonatoService($http) {
    //    var baseUrl = 'api/';
    //    var IniciarCampeonato = function (listaFilmes) {
    //        return (listaFilmes) => $http.post(baseUrl + 'IniciarCampeonato/', listaFilmes);
    //    };
    //    return {
    //        IniciarCampeonato: IniciarCampeonato,
    //    };
    //}

    function CampeonatoService($http) {
        var baseUrl = 'api/';
        var IniciarCampeonato = function (listaFilmes) {
            return $http.post(baseUrl + "IniciarCampeonato/", listaFilmes);
        };
        return {
            IniciarCampeonato: IniciarCampeonato,
        };
    }
})(angular.module('ngService'));