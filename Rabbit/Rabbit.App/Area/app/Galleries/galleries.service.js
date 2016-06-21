var app;
(function (app) {
    var Galleries;
    (function (Galleries) {
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
            GalleriesService.prototype.SaveNewGallery = function (post) {
                // return this.$http({
                //     method: 'POST',
                //     url: '/api/SaveNewGallery/',
                //     data: JSON.stringify(post),
                //     headers: {
                //         'Content-Type': "application/json"
                //     }
                // });
                return this.$http.post('/api/SaveNewGallery/', JSON.stringify(post), {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                });
            };
            GalleriesService.IID = 'GalleriesService';
            GalleriesService.$inject = ['$http'];
            return GalleriesService;
        }());
        Galleries.GalleriesService = GalleriesService;
        angular.module('app')
            .service(GalleriesService.IID, GalleriesService);
    })(Galleries = app.Galleries || (app.Galleries = {}));
})(app || (app = {}));
//# sourceMappingURL=galleries.service.js.map