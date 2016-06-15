(function () {
    'use strict';

    angular
        .module('RabbitApp')
        .service('dataservice', dataservice);

    dataservice.$inject = ['$http'];

    function dataservice($http) {
        var service = {
            getRabbits: getRabbits
        };

        return service;

        function getRabbits() {
            return $http({ method: 'GET', url: '/api/GetAllRabbit' }).
                success(function (data, status, headers, config) {
                    // this callback will be called asynchronously
                    // when the response is available
                    return data;
                }).
                error(function (data, status, headers, config) {
                    // called asynchronously if an error occurs
                    // or server returns response with an error status.
                });
        }
    }
})();