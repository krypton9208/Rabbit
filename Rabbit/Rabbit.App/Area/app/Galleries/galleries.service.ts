
namespace app.Galleries {
    'use strict';

    export class GalleriesService {
        static IID = 'GalleriesService';
        static $inject = ['$http'];
        constructor(public $http: angular.IHttpService) {};

        public GetAllGalleries(): any {
            return this.$http
                .get('/api/GetAllGalleries/');
        }

        public SaveNewGallery(post: INewPost){
            return this.$http.post('/api/SaveNewGallery/', JSON.stringify(post),   {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                });
        }
    }
    angular.module('app')
        .service(GalleriesService.IID, GalleriesService);
}