var app;
(function (app) {
    'use strict';
    var GalleriesService = (function () {
        function GalleriesService($http) {
            this.$http = $http;
            this.info = 'Working';
            this.name = 'Damian';
        }
        ;
        GalleriesService.prototype.GetInfo = function () {
            return this.info;
        };
        ;
        GalleriesService.prototype.getMyGalleries = function (myId) {
            return this.$http({
                method: 'get',
                url: "api/MyGalleries/" + myId
            }).then(function (result) { return result.data; });
        };
        GalleriesService.$inject = ['$http'];
        return GalleriesService;
    }());
    angular.module('app')
        .service('GalleriesService', GalleriesService);
})(app || (app = {}));
//# sourceMappingURL=galleries.service.js.map