app.service("creativeService", function ($http) {

    this.getPopularCreatives = function (scope) {
        scope.creatives = [];
        $http.get("/Creative/GetPopularCreatives/").then(function (response) {
            scope.creatives = response.data;
        });
    };

    this.getNewCreatives = function (scope) {
        scope.creatives = [];
        $http.get("/Creative/GetNewCreatives/").then(function (response) {
            scope.creatives = response.data;
        });
    };



});