var app;
(function (app) {
    'use strict';
    var GalleriesController = (function () {
        function GalleriesController(getMyGalleries, info) {
            this.getMyGalleries = getMyGalleries;
            this.siema = info;
        }
        GalleriesController.prototype.GetInfo = function () {
            return this.siema;
        };
        GalleriesController.$inject = ["GalleriesService"];
        return GalleriesController;
    }());
    angular.module('app')
        .controller('GalleriesController', GalleriesController);
})(app || (app = {}));
//# sourceMappingURL=galleries.controller.js.map