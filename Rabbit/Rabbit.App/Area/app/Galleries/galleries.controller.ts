
namespace app.Galleries {
    'use strict';

    class GalleriesController {
        public static IID = 'GalleriesController';
        static $inject = [app.Galleries.GalleriesService.IID];
        public Galleries: any;
        constructor(public service: app.Galleries.GalleriesService)
        {
            let vm = this;
                service.GetAllGalleries().
                    then((result: {
                        data: any;
                    }) => {
                        vm.Galleries = result.data;
                    });
        };

        public CreateGallery(post: INewPost){
            this.service.SaveNewGallery(post);
        }

    }
    angular.module('app')
        .controller(GalleriesController.IID, GalleriesController);
}