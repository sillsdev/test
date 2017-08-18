#!/bin/bash
# Trigger a build for the testproject. This is run on Jenkins.
[ -z $FWROOT ] && FWROOT=$(readlink -f $(dirname $0))
cd $FWROOT
. environ
xbuild testproject/testproject.sln
