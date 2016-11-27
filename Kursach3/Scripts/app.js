let app = angular.module("createApp", ["ngRoute", "ngResource", "ui.router"]).
    config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Creative/CreativeReader/:creativeId?', {
            controller: 'readController',
            templateUrl: '/Creative/CreativeReader.cshtml'
        });
    }).config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Home/SearchPage/:creativeId?', {
            controller: 'searchPageController',
            templateUrl: '/Home/SearchPage.cshtml'
        });
    });