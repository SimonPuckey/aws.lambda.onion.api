# ONION API
## Next Steps
* Each command workflow proj to also host a direct lambda entry point (as well as a web api controller)
* or we have a lambda host project and a web api host project
* TODO: Flesh out the create and update command workflows

## Notes (unstructured)
* Org.Update would cover all members of Org (if had more members)
  * Should we create a project per member update?
  * or only have projects for CrUd and 'Org.Update' defines multiple endpoints (or a single update with lower level routing)
  * I think the former because 
    * keeps closer to lambda decomp
  * but not gonna worry bout it for now
  * do need to keep thinking how to make this portable to lambda though

### Lambda Portability
Desire to run web api within lambda (which is a good idea)
But also want to decompose web api into commands (and queries) that can be deployed without web api host
So need to ensure these projects have
* a web api controller
* a lambda entry point 
  * to handle event directly from api gateway without translation back to http request

May be better to not contain the controller within the 'workflow'. then this workflow project could then be consumed by a lambda function or the web api