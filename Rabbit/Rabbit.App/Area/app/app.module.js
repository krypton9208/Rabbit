(function () {
    'use strict';

    angular
        .module('RabbitApp', ['ngAnimate', 'ngRoute'])
        .config(routeConfig);

    routeConfig.$inject = ['$routeProvider'];

    function routeConfig($routeProvider) {
        $routeProvider
            .when('/', { templateUrl: 'Area/app/Rabbits/Index.cshtml', title: 'Rabbit' })
            //.when('/avengers', { templateUrl: 'app/avengers/avengers.html', title: 'avengers' })
            .otherwise({ redirectTo: '/' });
    }
})();