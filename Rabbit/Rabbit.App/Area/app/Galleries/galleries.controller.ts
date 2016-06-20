
namespace app {
    'use strict';
    class GalleriesController {
        public static IID = 'GalleriesController';
        static $inject = [GalleriesService.IID];
        public Galleries: any;
        constructor(getall: GalleriesService)
        {
            let vm = this;
                getall.GetAllGalleries().
                    then((result: {
                        data: any;
                    }) => {
                        vm.Galleries = result.data;
                    });
        };


    }
    angular.module('app')
        .controller(GalleriesController.IID, GalleriesController);
}