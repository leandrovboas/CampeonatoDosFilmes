(function (app) {
    'use strict';
    app.factory('filmeService', filmeService);
    filmeService.$inject = ['$http'];

    function filmeService($http) {
        var baseUrl = 'api/filmes/';
        return {
            'obter': function (id) {
                return $http.get(baseUrl + "Obter/" + id);
            }
        };
    }
})(angular.module('ngService'));