#! /bin/bash 
###########################################
#
###########################################

# constants
baseDir=$(cd `dirname "$0"`;pwd)
WORKSPACE=/workspace
BUILD_DIR=$WORKSPACE/build

# functions

# main 
[ -z "${BASH_SOURCE[0]}" -o "${BASH_SOURCE[0]}" = "$0" ] || return

echo "clean build dir ..."
rm -rf $BUILD_DIR/*

cd $WORKSPACE/xapian-core
./configure --prefix=$BUILD_DIR
make
make install


#cd $WORKSPACE/xapian-bindings
#./configure --prefix=$BUILD_DIR \
#    XAPIAN_CONFIG=$WORKSPACE/xapian-core/xapian-config
