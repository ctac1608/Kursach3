app.controller("creativeController", function ($scope, $http, creativeServise) {

    $scope.creatives = [];

    creativeServise.getPopularCreative($scope);
    //creativeServise.getNewCreative($scope);

});