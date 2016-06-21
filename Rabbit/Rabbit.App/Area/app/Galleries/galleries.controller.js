var app;
(function (app) {
    var Galleries;
    (function (Galleries) {
        'use strict';
        var GalleriesController = (function () {
            function GalleriesController(service) {
                this.service = service;
                var vm = this;
                service.GetAllGalleries().
                    then(function (result) {
                    vm.Galleries = result.data;
                });
            }
            ;
            GalleriesController.prototype.CreateGallery = function (post) {
                this.service.SaveNewGallery(post);
            };
            GalleriesController.IID = 'GalleriesController';
            GalleriesController.$inject = [app.Galleries.GalleriesService.IID];
            return GalleriesController;
        }());
        angular.module('app')
            .controller(GalleriesController.IID, GalleriesController);
    })(Galleries = app.Galleries || (app.Galleries = {}));
})(app || (app = {}));
//# sourceMappingURL=galleries.controller.js.map