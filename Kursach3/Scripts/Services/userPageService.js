app.service("userPageService", function ($http) {
    
    this.getUser = function (scope) {
        $http.get("/UserPage/GetUser/").then(function (response) {
            scope.user = response.data;
            console.log(response);
        });
    };

    this.getUserCreatives = function (scope) {
        scope.creatives = [];
        $http.get("/UserPage/GetUserCreatives/").then(function (response) {
            scope.creatives = response.data;
        });
    };

    this.createCreative = function (scope) {
        var creative = {
            Name: scope.Name
        };
        $http.post("/UserPage/CreateCreative/", creative, function () {
        });
    };


});