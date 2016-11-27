app.controller("userCreativesController", function ($scope, $http, $window, $location, userPageService) {

    userPageService.getUserCreatives($scope);

    $scope.openCreative = function () {

        $window.location.href = "http://localhost:52038/Creative/CreativeReader/" + this.creative.Id;
    };

    //$scope.openCreative = function () {
    //    $state.go("creativeRead", { creativeId: this.creative.Id });
    //};

});