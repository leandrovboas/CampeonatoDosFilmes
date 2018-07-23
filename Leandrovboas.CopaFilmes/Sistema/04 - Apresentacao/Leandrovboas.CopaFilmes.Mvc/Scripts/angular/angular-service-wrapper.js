(function () {
    var app = angular.module('ngServiceWrapper', []);
    app.config(['$provide', '$httpProvider', function ($provide, $httpProvider) {
        $provide.factory('httpInterceptor', ['$q', function ($q) {
            return {
                'response': function (response) {
                    //resetTimer();
                    return response;
                }
            };
        }]);
        $httpProvider.interceptors.push('httpInterceptor');
    }]);
})();