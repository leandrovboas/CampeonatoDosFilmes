(function (app) {
    'use strict';
    app.factory('CampeonatoService', CampeonatoService);
    CampeonatoService.$inject = ['$http'];

    function CampeonatoService($http) {
        var baseUrl = 'api/';
        var enviarFilmes = function (model) {
            return (model) => $http.post('/Campeonato/index', model);
        };
        return {
            enviarFilmes: enviarFilmes,
        };
    }
})(angular.module('ngService'));