
# Convenience Script for building the docker image

# Inputs:
$dockerFile = './configuration-visualization/Dockerfile.alpine'
$repo = 'dekoeky'
$imageName = 'configuration-visualization'
$tag = 'test-alpine'

# Calculated Variables:
$fullRepoName = "${repo}/${imageName}"
$fullImageName = "${fullRepoName}:${tag}"

# Build:
# docker build --no-cache `
#   --tag $fullImageName `
#   -f $dockerFile .

docker buildx build --no-cache `
  --platform linux/arm64,linux/arm,linux/amd64 `
  --push `
  -f $dockerFile `
  --tag $fullImageName .

# # Show present tags:
# docker image ls $fullRepoName