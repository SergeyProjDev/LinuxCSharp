git push --set-upstream origin master
git add Makefile intruction test.cs update.sh
NOW=$(date +"%m-%d-%Y")
git commit -m $NOW
git push
