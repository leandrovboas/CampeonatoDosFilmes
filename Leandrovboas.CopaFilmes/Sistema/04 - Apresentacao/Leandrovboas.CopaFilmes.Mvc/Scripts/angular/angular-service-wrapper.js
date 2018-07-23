(function () {
    var app = angular.module('ngServiceWrapper', []);
    app.config(['$provide', '$httpProvider', function ($provide, $httpProvider) {
        if (angular.element('input[name="__RequestVerificationToken"]').length) {
            $httpProvider.defaults.headers.common['X-XSRF-Token'] = angular.element('input[name="__RequestVerificationToken"]').attr('value');
        }
        $provide.factory('httpInterceptor', ['$q', function ($q) {
            return {
                'response': function (response) {
                    resetTimer();
                    return response;
                }
            };
        }]);
        $httpProvider.interceptors.push('httpInterceptor');
    }]);
})();