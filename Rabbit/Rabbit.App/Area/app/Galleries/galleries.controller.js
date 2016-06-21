var app;
(function (app) {
    'use strict';
    var GalleriesController = (function () {
        function GalleriesController(getall) {
            var vm = this;
            getall.GetAllGalleries().
                then(function (result) {
                //das
                vm.Galleries = result.data;
            });
        }
        ;
        GalleriesController.IID = 'GalleriesController';
        GalleriesController.$inject = [app.GalleriesService.IID];
        return GalleriesController;
    }());
    angular.module('app')
        .controller(GalleriesController.IID, GalleriesController);
})(app || (app = {}));
//# sourceMappingURL=galleries.controller.js.map