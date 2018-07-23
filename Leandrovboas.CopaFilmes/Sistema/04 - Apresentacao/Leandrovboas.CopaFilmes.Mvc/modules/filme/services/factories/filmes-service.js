(function (app) {
    'use strict';
    app.factory('filmeService', filmeService);
    filmeService.$inject = ['$http'];

    function filmeService($http) {
        var baseUrl = 'api/filmes/';
        var getFilmes = function () {
            return $http.get(baseUrl + "listar/");
        };
        return {
            getFilmes: getFilmes,
        };
    }
})(angular.module('ngService'));