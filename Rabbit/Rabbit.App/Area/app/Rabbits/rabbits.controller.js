(function () {
    'use strict';

    RabbitCtrl.$inject = ['dataservice'];

    function RabbitCtrl(dataservice) {
        /* jshint validthis: true */
        var vm = this;

        vm.getRabbits = getRabbits;
        vm.isActive = isActive;
        vm.rabbits = [];
        vm.selectedRabbit = undefined;
        vm.name = 'Rabbits All together';

        activate();

        function activate() {
            return getRabbits();
        }

        function getRabbits() {
            return dataservice.getRabbits()
                .then(function (data) {
                    vm.rabbits = data.data;
                    return vm.selectedRabbit;
                });
        }

        function isActive(rabbit) {
            return !!(vm.selectedRabbit === rabbit);
        }
    }
    angular
       .module('RabbitApp')
       .controller('RabbitCtrl', RabbitCtrl);
})();