git push --set-upstream origin master
git add *
NOW=$(date +"%m-%d-%Y")
git commit -m $NOW
git push
