app.controller("popularCreativeController", function ($scope, creativeService) {

    creativeServise.getPopularCreative($scope);

});

app.controller("newCreativeController", function ($scope, creativeService) {

    creativeServise.getNewCreative($scope);

});