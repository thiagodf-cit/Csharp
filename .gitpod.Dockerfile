FROM gitpod/workspace-full:latest

USER gitpod
# Install custom tools, runtime, etc.
# RUN apt-get update && apt-get install -y \
#         gdb \
#         lldb \
#     && apt-get clean && rm -rf /var/cache/apt/* && rm -rf /var/lib/apt/lists/* && rm -rf /tmp/*