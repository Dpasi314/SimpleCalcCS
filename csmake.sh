if [ ! -e ./Project ]; then
	mkdir ./Project
fi

flag=$1

get_compile_list() {
	find . -name "*.cs" | grep -o -P "(?<=^..)(.*.$1)" > Project/projfiles.txt;
	sed -e :a -e '$!N; s/\n/ /; ta' Project/projfiles.txt > Project/to_compile.txt;
	info=$(<Project/to_compile.txt);
	echo "$info";

}

if [ $# == 0 ]; then
	info=$(get_compile_list ".cs");
	mcs -out:out.exe $info;
	exit;
fi

if [ $flag == "--spec" ]; then
	info=$(get_compile_list "$2")
	echo "Modified to use $2...";
	# TODO: Special compiler functions
	exit;
fi

if [ $flag == "--clean" ]; then
	rm -rf ./Project;
	rm out.exe;
	exit;
fi
