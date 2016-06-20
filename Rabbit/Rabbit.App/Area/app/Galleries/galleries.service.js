var app;
(function (app) {
    'use strict';
    var GalleriesService = (function () {
        function GalleriesService($http) {
            this.$http = $http;
        }
        ;
        GalleriesService.prototype.GetAllGalleries = function () {
            return this.$http
                .get('/api/GetAllGalleries/');
        };
        GalleriesService.IID = 'GalleriesService';
        GalleriesService.$inject = ['$http'];
        return GalleriesService;
    }());
    app.GalleriesService = GalleriesService;
    angular.module('app')
        .service(GalleriesService.IID, GalleriesService);
})(app || (app = {}));
//# sourceMappingURL=galleries.service.js.map