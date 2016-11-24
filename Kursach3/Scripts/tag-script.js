

app.controller("tagSearchController", function ($scope) {
    $scope.tags = [];

    // Add tag function
    $scope.addTag = function () {
        if ($scope.tagText.length != 0) {
            $scope.tags.push({
                name: $scope.tagText
            });
            $scope.tagText = '';
        }
    };

    // Remove tag function
    $scope.removeTag = function (tagId) {
        if ($scope.tags.length != 0) {
            $scope.tags.splice(tagId, 1);
        }
    }
});

app.directive("tagInput", function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            scope.inputWidth = 300;
            // Watch width changes
            scope.$watch(attrs.ngModel, function (value) {
                if (value != undefined) {

                }
            });

            // Key press function
            element.bind('keydown', function (event) {
                if (event.which == 9)
                    event.preventDefault();
            })
            element.bind('keyup', function (event) {
                var key = event.which;
                if (key == 9 || key == 13) {
                    event.preventDefault();
                    scope.$apply(attrs.newTag);
                }
            })
        }
    }
});